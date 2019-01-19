using System;

namespace Jst4Code
{
    public interface IResult<T> { }

    public abstract class Result<T> : MayBe<T>, IResult<T>
    {
        public bool IsSuccess { get => HasValue; }
        public bool IsFailure { get => this is Error<T>; }

        public static implicit operator Result<T>(Exception ex) =>
            new Error<T>(ex);

        public static implicit operator Result<T>(T obj) =>
            obj != null ? (Result<T>)new Some<T>(obj) : new None<T>();

        public static implicit operator Result<T>(None obj)
            => new None<T>();

        public static implicit operator Result<T>(Try<T> @try)
            => @try.Try();
    }
}
