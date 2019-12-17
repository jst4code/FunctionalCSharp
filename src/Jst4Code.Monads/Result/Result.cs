using Jst4Code.Monads;
using System;

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

        public static implicit operator Result<T>(Try<T> @try)
            => @try.Try();

        public Result<T> OnException<TException>(T defaultValue)
            where TException : Exception 
                => this.OnException(defaultValue, ex => ex is TException);

        public Result<T> OnException<TException>(Func<TException, T> mapValue)
            where TException : Exception
                => this is ExceptionResult<T> exceptionResult && exceptionResult.Is<TException>()
                        ? mapValue((Exception)exceptionResult as TException)
                        : this;
    }

    internal class ExceptionResult<T> : Result<T>
    {
        private Exception Content { get; }

        public ExceptionResult(Exception content)
            => Content = content;

        public static implicit operator Exception(ExceptionResult<T> obj)
            => obj.Content;

        public bool Is<TException>() 
            where TException : Exception
                => Content is TException;
    }

    internal class ValueResult<T> : Result<T>
    {
        private T Content { get; }

        public ValueResult(T content)
            => Content = content;

        public static implicit operator T(ValueResult<T> obj)
            => obj.Content;
    }

    internal class NoneResult<T> : Result<T>
    {
    }

    public static class ResultAdapters
    {
        public static void OnSuccess<T>(this Result<T> source, Action<T> toDo)
        {
            if (source is ValueResult<T> result)
            {
                toDo(result);
            }
        }

        public static TResult Reduce<TResult>(
            this Result<TResult> result,
            TResult whenNoneOrFaulted) =>
                result is ExceptionResult<TResult> || result is NoneResult<TResult>
                    ? whenNoneOrFaulted
                    : (ValueResult<TResult>)result;

        public static Result<TResult> OnException<TResult>(
            this Result<TResult> result,
                TResult mapValue,
                Func<Exception, bool> when) =>
                    result is ExceptionResult<TResult> exceptionResult && when(exceptionResult)
                        ? mapValue
                        : result;

        public static Result<TResult> OnException<TResult>(
            this Result<TResult> result,
                Func<Exception, TResult> mapValue,
                Func<Exception, bool> when) =>
                    result is ExceptionResult<TResult> exceptionResult && when(exceptionResult)
                        ? mapValue(exceptionResult)
                        : result;

        public static Result<TResult> OnNone<TResult>(
            this Result<TResult> result,
                TResult mapValue)
                    => result is NoneResult<TResult>
                        ? mapValue
                        : result;

        public static Result<TOut> Map<TIn, TOut>(
            this Result<TIn> source,
            Func<TIn, TOut> map) 
            => source switch
                {
                    ExceptionResult<TIn> ex => (Exception)ex,
                    ValueResult<TIn> val => map(val),
                    _ => new NoneResult<TOut>(),
                };

    }
}
