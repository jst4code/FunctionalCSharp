using System;
using Xunit;
using FluentAssertions;


namespace Jst4Code.FunctionalCSTests
{
    public class ResultTests
    {
        [Theory]
        [InlineData("9", 3)]
        [InlineData(null, -1)]
        [InlineData("abc", -2)]
        [InlineData("123456789123456789123456789123456789", 0)]
        public void Should_be_able_to_try(string input, double expected)
        {
            var result = input
                .Try(int.Parse)
                .Map(Convert.ToDouble)
                .Map(Math.Sqrt)
                .Reduce(-1, ex => ex is ArgumentNullException)
                .Reduce(-2, ex => ex is FormatException)
                .Reduce(0);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("9", 3)]
        [InlineData(null, 0)]
        [InlineData("abc", -2)]
        [InlineData("123456789123456789123456789123456789", 0)]
        public void Should_be_able_to_handle_none_results(string input, double expected)
        {
            Result<string> resultInput = input;
            var result = resultInput
                .Try(int.Parse)
                .Map(Convert.ToDouble)
                .Map(Math.Sqrt)
                .Reduce(-1, ex => ex is ArgumentNullException)
                .Reduce(-2, ex => ex is FormatException)
                .Reduce(0);
            result.Should().Be(expected);
        }
    }
}
