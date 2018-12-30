using Jst4Code.Monads;
using System;
using System.Threading.Tasks;

namespace Jst4Code
{
    public abstract class Result<T>
    {
        public static implicit operator Result<T>(Exception ex) =>
            new ExceptionResult<T>(ex);

        public static implicit operator Result<T>(T obj) =>
            obj != null ? (Result<T>)new ValueResult<T>(obj) : new NoneResult<T>();

        public static implicit operator Result<T>(None obj)
            => new NoneResult<T>();
    }

    public class ExceptionResult<T> : Result<T>
    {
        private Exception Content { get; }

        public ExceptionResult(Exception content)
            => Content = content;

        public static implicit operator Exception(ExceptionResult<T> obj)
            => obj.Content;
    }

    public class ValueResult<T> : Result<T>
    {
        private T Content { get; }

        public ValueResult(T content)
            => Content = content;

        public static implicit operator T(ValueResult<T> obj)
            => obj.Content;
    }

    public class NoneResult<T> : Result<T>
    {
    }

    public static class ResultAdapters
    {
        public static Result<TOut> Try<TIn, TOut>(
            this TIn source,
            Func<TIn, TOut> select)
        {
            try
            {
                return select(source);
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public static Result<TOut> Try<TIn, TOut>(
            this Result<TIn> source,
            Func<TIn, TOut> select)
        {
            switch (source)
            {
                case ExceptionResult<TIn> ex: return (Result<TOut>)(Exception)ex;
                case ValueResult<TIn> val: return Try((TIn)val, select);
                case NoneResult<TIn> _:
                default:
                    return new NoneResult<TOut>();
            }
        }

        public static TResult Reduce<TResult>(
            this Result<TResult> result,
            TResult whenNoneOrFaulted) =>
                result is ExceptionResult<TResult> || result is NoneResult<TResult>
                    ? whenNoneOrFaulted
                    : (ValueResult<TResult>)result;

        public static Result<TResult> Reduce<TResult>(
            this Result<TResult> result,
                TResult mapValue,
                Func<Exception, bool> when) =>
                    result is ExceptionResult<TResult> exceptionResult && when(exceptionResult)
                        ? mapValue
                        : result;

        public static Result<TOut> Map<TIn, TOut>(
            this Result<TIn> source,
            Func<TIn, TOut> map)
        {
            switch (source)
            {
                case ExceptionResult<TIn> ex: return (Result<TOut>)(Exception)ex;
                case ValueResult<TIn> val: return map(val);
                case NoneResult<TIn> _:
                default:
                    return new NoneResult<TOut>();
            }
        }
    }

    public static class ResultAdaptersAsync
    {
        public static async Task<Result<TOut>> TryAsync<TIn, TOut>(
            this TIn source,
            Func<TIn, TOut> select) 
                => await Task.Factory.StartNew(() => source.Try(select));
    }

}
