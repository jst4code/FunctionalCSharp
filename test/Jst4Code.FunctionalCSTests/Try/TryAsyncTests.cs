using System;
using NUnit.Framework;
using FluentAssertions;
using System.Threading.Tasks;

namespace Jst4Code.FunctionalCSTests
{
    public class TryAsyncTests
    {
        [TestCase("9", 3)]
        [TestCase("abc", -2)]
        [TestCase("123456789123456789123456789123456789", 0)]
        public async Task Should_be_able_to_catch_exceptions(string input, double expected)
        {
            var tryResult = await input.AsTryAsync()
                .Map(int.Parse)
                .Map(Convert.ToDouble)
                .Map(Math.Sqrt)
                .Try();

            var result = tryResult
                .OnException(-1, ex => ex is ArgumentNullException)
                .OnException(-2, ex => ex is FormatException)
                .Reduce(0);

            result.Should().Be(expected);
        }


        [TestCase("9", 3)]
        [TestCase(null, -3)]
        public async Task Should_be_able_to_catch_none(string input, double expected)
        {
            var tryResult = await input
                .AsTryAsync()
                .Map(int.Parse)
                .Map(Convert.ToDouble)
                .Map(Math.Sqrt)
                .Try();

            var result = tryResult
                .OnNone(-3)
                .Reduce(0);

            result.Should().Be(expected);
        }
    }
}
