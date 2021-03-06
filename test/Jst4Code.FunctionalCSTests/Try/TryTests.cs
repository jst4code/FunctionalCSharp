﻿using System;
using NUnit.Framework;
using FluentAssertions;


namespace Jst4Code.FunctionalCSTests
{
    public class TryTests
    {
        private Func<string, Try<double>> parseAndSqrt = input => input.AsTry()
                .Map(int.Parse)
                .Map(Convert.ToDouble)
                .Map(Math.Sqrt);

        [TestCase("9", 3)]
        [TestCase("abc", -2)]
        [TestCase("123456789123456789123456789123456789", 0)]
        public void Should_be_able_to_catch_exceptions(string input, double expected)
        {
            var result = input.AsTry()
                .Map(int.Parse)
                .Map(Convert.ToDouble)
                .Map(Math.Sqrt)
                .Try()
                .OnException(-1, ex => ex is ArgumentNullException)
                .OnException(-2, ex => ex is FormatException)
                .Reduce(0);

            result.Should().Be(expected);
        }


        
        [TestCase("9", 3)]
        [TestCase(null, -3)]
        public void Should_be_able_to_catch_none(string input, double expected)
        {
            var result = input
                .AsTry()
                .Map(int.Parse)
                .Map(Convert.ToDouble)
                .Map(Math.Sqrt)
                .Try()
                .OnNone(-3)
                .Reduce(0);

            result.Should().Be(expected);
        }
    }
}
