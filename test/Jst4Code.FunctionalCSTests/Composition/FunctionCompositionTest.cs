using System;
using FluentAssertions;
using Jst4Code.FunctionalCS.Composition;
using NUnit.Framework;

namespace Jst4Code.FunctionalCSTests.Composition
{
    public class FunctionCompositionTest
    {
        Func<string, string> appendHello = s => string.Join("", s, "Hello");
        Func<string, string> appendWorld = s => string.Join("", s, "World");

        Func<string, int> parse = int.Parse; // string -> int
        Func<int, double> convert = Convert.ToDouble; // int -> double
        Func<double, double> sqrt = Math.Sqrt; // double -> double

        [Test]
        public void Should_execute_Method_after_first_one()
        {
            // Act
            var result = appendWorld.After(appendHello)(string.Empty);
            result.Should().Be("HelloWorld");
        }

        [Test]
        public void Should_execute_method_after_first_one_with_different_types()
        {
            Func<string, double> processor = sqrt.After(convert).After(parse);
            var result = processor("4");
            result.Should().Be(2);
        }

        [Test]
        public void Should_execute_Method_and_then_the_second_one()
        {
            // Act
            var result = appendHello.Then(appendWorld)(string.Empty);
            result.Should().Be("HelloWorld");
        }

        [Test]
        public void Should_execute_Method_and_then_the_second_one_with_different_types()
        {
            // Act
            Func<string, double> processor = parse.Then(convert).Then(sqrt);
            var result = processor("4");
            result.Should().Be(2);
        }

        [Test]
        public void Should_pipe_method_in_forward_direction()
        {
            // Act
            var result = "4".Select(int.Parse).Select(Convert.ToDouble).Select(Math.Sqrt);
            result.Should().Be(2);
        }
    }
}
