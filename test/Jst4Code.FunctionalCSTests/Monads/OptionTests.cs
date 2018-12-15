using FluentAssertions;
using Jst4Code.Monads;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Jst4Code.FunctionalCSTests.Monads
{
    public class OptionTests
    {
        [Fact]
        public void Should_implicitly_typecast_to_ToOptional()
        {
            Option<string> val = "hello world";
            val.Reduce(string.Empty).Should().Be("hello world");
        }

        [Fact]
        public void Should_implicitly_typecast_null_to_ToOptional()
        {
            Option<string> val = null;
            val.Reduce("nothing").Should().Be("nothing");
        }

        [Fact]
        public void Should_be_able_to_chain()
        {
            Option<string> val = "hello";
            var collection = val
                .Map(i => i.Length)
                .Map(i => Enumerable.Range(0, i))
                .Reduce(Enumerable.Empty<int>());

            collection.Count().Should().Be(5);
        }

        [Fact]
        public void Should_be_able_to_chain_null()
        {
            Option<string> val = null;
            var collection = val
                .Map(i => i.Length)
                .Map(i => Enumerable.Range(0, i))
                .Reduce(Enumerable.Empty<int>());

            collection.Count().Should().Be(0);
        }
    }
}
