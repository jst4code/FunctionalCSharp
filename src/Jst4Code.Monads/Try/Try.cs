using Jst4Code.Monads;
using System;
using System.Diagnostics.Contracts;

namespace Jst4Code
{
    public delegate Result<T> Try<T>();

    // TODO
    //public delegate Result<TResult> Use<TResult, TDisposable>(TDisposable disposable)
    //    where TDisposable : IDisposable;

    public static class TryAdapters
    {
        /// <summary>
        /// Try identity constructor function
        /// </summary>
        /// <typeparam name="A">Bound value type</typeparam>
        /// <param name="v">Bound value to return</param>
        /// <returns>A lifted operation that returns a value of A</returns>
        [Pure]
        public static Try<A> AsTry<A>(this A v) =>
            () => v;

        public static Try<A> AsTry<A>(this Func<A> func)
        {
            return () =>
               {
                   Result<A> result = None.Value;

                   try { result = func(); }
                   catch (Exception ex) { result = ex; }

                   return result;
               };
        }

        public static Result<T> Try<T>(this Try<T> self)
        {
            if (self == null) return None.Value;

            try { return self(); }
            catch (Exception ex) { return ex; }
        }

        /// <summary>
        /// Memoize the computation so that it's only run once
        /// </summary>
        public static Try<A> Memo<A>(this Try<A> ma)
        {
            bool run = false;
            Result<A> result = None.Value;

            return (() =>
            {
                if (run) return result;
                result = ma.Try();
                run = true;
                return result;
            });
        }

        /// <summary>
        /// Maps the bound value
        /// </summary>
        /// <typeparam name="A">Type of the bound value</typeparam>
        /// <typeparam name="R">Resulting bound value type</typeparam>
        /// <param name="self">Try computation</param>
        /// <param name="mapper">Delegate to map the bound value</param>
        /// <returns>Mapped Try computation</returns>
        [Pure]
        public static Try<B> Map<A, B>(this Try<A> self, Func<A, B> f) =>
            Memo(() => self.Try().Map(f));

        /// <summary>
        /// Maps the bound value
        /// </summary>
        /// <typeparam name="A">Type of the bound value</typeparam>
        /// <typeparam name="R">Resulting bound value type</typeparam>
        /// <param name="self">Try computation</param>
        /// <param name="mapper">Delegate to map the bound value</param>
        /// <returns>Mapped Try computation</returns>
        [Pure]
        public static Try<T> Then<T>(this Try<T> self, Action<T> f) =>
            Memo(() =>
            {
                Result<T> result = self.Try();

                if (result is ValueResult<T> val) f(val);

                return result;
            });

        public static Result<A> Try<A>(this Func<A> func)
        {
            try { return func(); }
            catch (Exception ex) { return ex; }
        }
    }
}
