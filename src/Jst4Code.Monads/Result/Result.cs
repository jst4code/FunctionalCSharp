using System;

namespace Jst4Code
{
    public abstract class Result<T>
    {
        public static implicit operator Result<T>(T obj) =>
            new ResultValue<T>(obj);

        public static implicit operator Result<T>(Exception ex) =>
            new ExceptionResult<T>(ex);
    }

    public class ExceptionResult<T> : Result<T>
    {
        private Exception Exception { get; }

        public ExceptionResult(Exception ex)
        {
            Exception = ex;
        }

        public static implicit operator Exception(ExceptionResult<T> obj) =>
            obj.Exception;
        public static implicit operator ExceptionResult<T>(Exception ex) =>
            new ExceptionResult<T>(ex);
    }

    public class ResultValue<T> : Result<T>
    {
        private T Content { get; }

        public ResultValue(T content)
        {
            Content = content;
        }

        public static implicit operator T(ResultValue<T> obj) =>
            obj.Content;
    }

    public static class ResultExtensions
    {
        public static Result<TOut> Try<TIn, TOut>(this TIn source, Func<TIn, TOut> select)
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

        public static TResult Reduce<TResult>(
            this Result<TResult> result,
            Func<Exception, TResult> map) =>
                result is ExceptionResult<TResult> exceptionResult
                    ? map(exceptionResult)
                    : (ResultValue<TResult>)result;

        public static Result<TResult> Reduce<TResult>(
            this Result<TResult> result,
            TResult mapValue,
            Func<Exception, bool> when) =>
                result is ExceptionResult<TResult> exceptionResult && when(exceptionResult)
                    ? mapValue
                    : result;

        public static Result<TOut> Map<TIn, TOut>(
            this Result<TIn> source, 
            Func<TIn, TOut> map) =>
                source is ExceptionResult<TIn> exceptionResult
                    ? (Result<TOut>)(Exception)exceptionResult
                    : map((ResultValue<TIn>)source);
    }

}
