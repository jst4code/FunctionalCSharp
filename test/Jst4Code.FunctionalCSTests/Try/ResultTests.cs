using System;
using FluentAssertions;
using NUnit.Framework;
using System.Collections;

namespace Jst4Code.FunctionalCSTests
{
    public class ResultTests
    {
        [TestCase("9", 3)]
        [TestCase(null, 0)]
        public void Should_be_able_to_handle_none_results(string input, double expected)
        {
            // Arrange
            Result<string> resultInput = input;

            var result = resultInput
                .Map(int.Parse)
                .Map(Convert.ToDouble)
                .Map(Math.Sqrt);

            // Act
            double value = result
                .OnException(ex => -1, ex => ex is ArgumentNullException)
                .OnException(-2, ex => ex is FormatException)
                .Reduce(0);

            // Assert
            value.Should().Be(expected);
        }

        [TestCaseSource(nameof(ExceptionTestDataSource))]
        public void Should_be_able_to_handle_exception_results(Exception input, double expected)
        {
            // Arrange
            Result<string> resultInput = input;

            var result = resultInput
                .Map(int.Parse)
                .Map(Convert.ToDouble)
                .Map(Math.Sqrt);

            // Act
            double value = result
                .OnException<ArgumentNullException>(-1)
                .OnException<FormatException>(ex => -2)
                .OnException(ex => (ex as NumericException).ErrorCode, ex => ex is NumericException)
                .Reduce(0);

            // Assert
            value.Should().Be(expected);
        }

        public static IEnumerable ExceptionTestDataSource
        {
            get
            {
                yield return new TestCaseData(new ArgumentNullException(), -1);
                yield return new TestCaseData(new FormatException(), -2);
                yield return new TestCaseData(new NumericException(5), 5);
                yield return new TestCaseData(new NumericException(100), 100);
            }
        }
    }

    public class NumericException : Exception
    {
        public NumericException(int errorCode) => ErrorCode = errorCode;

        public int ErrorCode { get; }
    }
}
