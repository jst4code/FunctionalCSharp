using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace Jst4Code
{
    public static class TryAsyncAdapter
    {
        [Pure]
        public static TryAsync<A> AsTryAsync<A>(this A v) =>
            () => Task.FromResult<Result<A>>(v);

        public static TryAsync<A> Memoize<A>(this TryAsync<A> ma)
        {
            bool run = false;
            Task<Result<A>> result = Task.FromResult<Result<A>>(None.Value);
            return new TryAsync<A>(() =>
            {
                if (run) return result;
                result = ma.Try();
                run = true;
                return result;
            });
        }

        [Pure]
        public static async Task<Result<T>> Try<T>(this TryAsync<T> self)
        {
            if (self == null) return None.Value;
            try
            {
                return await self();
            }
            catch (Exception e)
            {
                return e;
            }
        }

        [Pure]
        public static async Task<Result<B>> Try<A,B>(this TryAsync<A> self, Func<A,Task<B>> select)
        {
            if (self == null) return None.Value;
            try
            {
                var result = await self();
                if (result is Some<A> res)
                {
                    return await select(res);
                }
                return None.Value;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        [Pure]
        public static async Task<Result<B>> Try<A, B>(this TryAsync<A> self, Func<A, B> select)
        {
            if (self == null) return None.Value;
            try
            {
                var result = await self();
                return result.Map(select);
            }
            catch (Exception e)
            {
                return e;
            }
        }


        [Pure]
        public static async Task<Result<T>> Try<T>(this TryAsync<T> self, Func<T, Task> onSuccess)
        {
            if (self == null) return None.Value;
            try
            {
                var result = await self();

                if (result is Some<T> res)
                {
                    await onSuccess(res);
                }

                return result;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        [Pure]
        public static TryAsync<B> Map<A, B>(this TryAsync<A> self, Func<A, B> f) =>
           Memoize(async () => await self.Try(f));

        [Pure]
        public static TryAsync<T> Then<T>(this TryAsync<T> self, Action<T> f) =>
            Memoize(async () =>
            {
                Result<T> result = await self.Try();

                if (result is Some<T> val) f(val);

                return result;
            });
    }
}
