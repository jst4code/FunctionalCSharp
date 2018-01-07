using Jst4Code.FunctionalCS.Curry;
using System;
using Xunit;

namespace Jst4Code.FunctionalCSTests
{
    public class UnitTest1
    {
        [Fact]
        public void Curry2Params()
        {
            Func<int, int, int> add = (a, b) => a + b;
            int addResult = add(1, 2);
            Func<int, Func<int, int>> curriedAdd = add.Curry();

            int curriedAdd2Result = curriedAdd(1)(2);

            Assert.Equal(addResult, curriedAdd2Result);
        }
    }
}
