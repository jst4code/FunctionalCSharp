using FluentAssertions;
using Jst4Code.Monads;
using System;
using Xunit;

namespace Jst4Code.FunctionalCSTests.Monads
{
    public class EitherTests
    {
        [Fact]
        public void Should_select_lfet()
        {
            Either<Exception, string> either = "hello world";
            either
                .Reduce(ex => string.Empty)
                .Should().Be("hello world");
        }

        [Fact]
        public void Should_select_exception()
        {
            Either<Exception, string> either = new NotImplementedException();
            either
                .Reduce(ex => "null", ex => ex is NullReferenceException)
                .Reduce(ex => "not", ex => ex is NotImplementedException)
                .Reduce(ex => string.Empty)
                .Should().Be("not");
        }
    }
}
