using FluentAssertions;
using System;
using System.Linq;
using NUnit.Framework;

namespace Jst4Code.FunctionalCSTests.Monads
{
    public class OptionTests
    {
        Func<string, int> parse = int.Parse; // string -> int
        Func<int, double> convert = Convert.ToDouble; // int -> double
        Func<double, double> sqrt = Math.Sqrt; // double -> double

        [Test]
        public void Should_implicitly_typecast_to_ToOptional()
        {
            MayBe<string> val = "hello world";
            val.Reduce(string.Empty).Should().Be("hello world");
        }

        [Test]
        public void Should_implicitly_typecast_null_to_ToOptional()
        {
            MayBe<string> val = null;
            val.Reduce("nothing").Should().Be("nothing");
        }

        [Test]
        public void Should_be_able_to_chain()
        {
            MayBe<string> val = "hello";
            var collection = val
                .Map(i => i.Length)
                .Map(i => Enumerable.Range(0, i))
                .Reduce(Enumerable.Empty<int>());

            collection.Count().Should().Be(5);
        }

        [Test]
        public void Should_be_able_to_chain_null()
        {
            MayBe<string> val = null;
            var collection = val
                .Map(i => i.Length)
                .Map(i => Enumerable.Range(0, i))
                .Reduce(Enumerable.Empty<int>());

            collection.Count().Should().Be(0);
        }

        
        [TestCase("9", 3)]
        [TestCase(null, 0)]
        public void Should_be_able_to_chain_with_map(string input, double expected)
        {
            MayBe<string> val = input;
            var result = val
                .Map(parse)
                .Map(convert)
                .Map(sqrt)
                .Reduce(0);
            result.Should().Be(expected);
        }
    }
}
