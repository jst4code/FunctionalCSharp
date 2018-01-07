using System;
using Xunit;
using Jst4Code.FunctionalCS.Curry;

namespace Jst4Code.FunctionalCSExtensionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Func<int, int, int> add2 = (a, b) => a + b;
            int add2Result = add2(1, 2);
            Func<int, Func<int, int>> curriedAdd2 = add2.Curry();

            int curriedAdd2Result = curriedAdd2(1)(2);

            Assert.Equal(add2Result, curriedAdd2Result);
        }
    }
}
