using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace Jst4Code
{
    public static class TryAdapters
    {
        [Pure]
        public static Try<A> AsTry<A>(this A v) =>
            () => v;

        public static TryAsync<A> ToAsync<A>(this Try<A> self) => () => Task.FromResult(self.Try());

        public static Result<T> Try<T>(this Try<T> self)
        {
            if (self == null) return None.Value;

            try
            {
                return self();
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public static Try<A> Memoize<A>(this Try<A> ma)
        {
            Lazy<Result<A>> result = new Lazy<Result<A>>(() => ma.Try());
            return () => result.Value;
        }

        [Pure]
        public static Try<B> Map<A, B>(this Try<A> self, Func<A, B> f) =>
            Memoize(() => self.Try().Map(f));

        [Pure]
        public static Try<T> Then<T>(this Try<T> self, Action<T> f) =>
            Memoize(() =>
            {
                Result<T> result = self.Try();

                if (result is Some<T> val) f(val);

                return result;
            });

        [Pure]
        public static Try<U> Use<T, U>(this Try<T> self, Func<T, U> select)
            where T : IDisposable =>
            self.Map(x => x.Use(select));

        /// <summary>
        /// Functional implementation of the using(...) { } pattern
        /// </summary>
        /// <param name="disposable">Disposable to use</param>
        /// <param name="f">Inner map function that uses the disposable value</param>
        /// <returns>Result of f(disposable)</returns>
        public static B Use<A, B>(this A disposable, Func<A, B> f)
            where A : IDisposable
        {
            try
            {
                return f(disposable);
            }
            finally
            {
                disposable?.Dispose();
            }
        }
    }
}
