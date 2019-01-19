using System;

namespace Jst4Code
{
    internal class Error<T> : Result<T>, IResult<T>
    {
        private Exception Content { get; }

        public Error(Exception content)
            => Content = content;

        public static implicit operator Exception(Error<T> obj)
            => obj.Content;
    }
}
