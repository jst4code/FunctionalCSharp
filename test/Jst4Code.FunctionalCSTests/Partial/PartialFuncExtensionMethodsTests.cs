using Jst4Code.FunctionalCS;
using System;
using System.Linq;
using NUnit.Framework;

namespace Jst4Code.FunctionalCSTests.Partial
{
	public class PartialFuncExtensionMethodTests
	{
	
		#region Partial<T1, T2, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial2Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2;

            Func<int, int, int[]> createArray = (in1, in2) => new int[] { in1, in2 };
            var expected = createArray(value1, value2);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial2Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2;

            Func<int, int, int[]> createArray = (in1, in2) => new int[] { in1, in2 };
            var expected = createArray(value1, value2);

            // Act
            var arrayFromPartial = createArray.Partial(value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial3Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3;

            Func<int, int, int, int[]> createArray = (in1, in2, in3) => new int[] { in1, in2, in3 };
            var expected = createArray(value1, value2, value3);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial3Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3;

            Func<int, int, int, int[]> createArray = (in1, in2, in3) => new int[] { in1, in2, in3 };
            var expected = createArray(value1, value2, value3);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial3Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3;

            Func<int, int, int, int[]> createArray = (in1, in2, in3) => new int[] { in1, in2, in3 };
            var expected = createArray(value1, value2, value3);

            // Act
            var arrayFromPartial = createArray.Partial(value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial3Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3;

            Func<int, int, int, int[]> createArray = (in1, in2, in3) => new int[] { in1, in2, in3 };
            var expected = createArray(value1, value2, value3);

            // Act
            var arrayFromPartial = createArray.Partial(value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial4Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4;

            Func<int, int, int, int, int[]> createArray = (in1, in2, in3, in4) => new int[] { in1, in2, in3, in4 };
            var expected = createArray(value1, value2, value3, value4);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial4Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4;

            Func<int, int, int, int, int[]> createArray = (in1, in2, in3, in4) => new int[] { in1, in2, in3, in4 };
            var expected = createArray(value1, value2, value3, value4);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial4Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4;

            Func<int, int, int, int, int[]> createArray = (in1, in2, in3, in4) => new int[] { in1, in2, in3, in4 };
            var expected = createArray(value1, value2, value3, value4);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial4Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4;

            Func<int, int, int, int, int[]> createArray = (in1, in2, in3, in4) => new int[] { in1, in2, in3, in4 };
            var expected = createArray(value1, value2, value3, value4);

            // Act
            var arrayFromPartial = createArray.Partial(value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial4Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4;

            Func<int, int, int, int, int[]> createArray = (in1, in2, in3, in4) => new int[] { in1, in2, in3, in4 };
            var expected = createArray(value1, value2, value3, value4);

            // Act
            var arrayFromPartial = createArray.Partial(value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial4Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4;

            Func<int, int, int, int, int[]> createArray = (in1, in2, in3, in4) => new int[] { in1, in2, in3, in4 };
            var expected = createArray(value1, value2, value3, value4);

            // Act
            var arrayFromPartial = createArray.Partial(value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial5Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;

            Func<int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5) => new int[] { in1, in2, in3, in4, in5 };
            var expected = createArray(value1, value2, value3, value4, value5);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial5Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;

            Func<int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5) => new int[] { in1, in2, in3, in4, in5 };
            var expected = createArray(value1, value2, value3, value4, value5);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial5Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;

            Func<int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5) => new int[] { in1, in2, in3, in4, in5 };
            var expected = createArray(value1, value2, value3, value4, value5);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial5Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;

            Func<int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5) => new int[] { in1, in2, in3, in4, in5 };
            var expected = createArray(value1, value2, value3, value4, value5);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial5Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;

            Func<int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5) => new int[] { in1, in2, in3, in4, in5 };
            var expected = createArray(value1, value2, value3, value4, value5);

            // Act
            var arrayFromPartial = createArray.Partial(value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial5Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;

            Func<int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5) => new int[] { in1, in2, in3, in4, in5 };
            var expected = createArray(value1, value2, value3, value4, value5);

            // Act
            var arrayFromPartial = createArray.Partial(value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial5Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;

            Func<int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5) => new int[] { in1, in2, in3, in4, in5 };
            var expected = createArray(value1, value2, value3, value4, value5);

            // Act
            var arrayFromPartial = createArray.Partial(value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial5Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;

            Func<int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5) => new int[] { in1, in2, in3, in4, in5 };
            var expected = createArray(value1, value2, value3, value4, value5);

            // Act
            var arrayFromPartial = createArray.Partial(value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial6Params_With5Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5);
            var fromPartialFunction = arrayFromPartial(value6);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial6Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5, value6);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial6Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5, value6);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial6Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5, value6);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial6Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5, value6);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial6Params_With5Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromPartial = createArray.Partial(value6);
            var fromPartialFunction = arrayFromPartial(value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial6Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromPartial = createArray.Partial(value6, value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial6Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromPartial = createArray.Partial(value6, value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial6Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromPartial = createArray.Partial(value6, value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial6Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromPartial = createArray.Partial(value6, value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial7Params_With6Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6);
            var fromPartialFunction = arrayFromPartial(value7);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial7Params_With5Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5);
            var fromPartialFunction = arrayFromPartial(value6, value7);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial7Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5, value6, value7);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial7Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5, value6, value7);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial7Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5, value6, value7);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial7Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5, value6, value7);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial7Params_With6Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value7);
            var fromPartialFunction = arrayFromPartial(value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial7Params_With5Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value7, value6);
            var fromPartialFunction = arrayFromPartial(value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial7Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value7, value6, value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial7Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value7, value6, value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial7Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value7, value6, value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial7Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromPartial = createArray.Partial(value7, value6, value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial8Params_With7Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7);
            var fromPartialFunction = arrayFromPartial(value8);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With6Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6);
            var fromPartialFunction = arrayFromPartial(value7, value8);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With5Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5);
            var fromPartialFunction = arrayFromPartial(value6, value7, value8);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5, value6, value7, value8);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5, value6, value7, value8);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5, value6, value7, value8);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5, value6, value7, value8);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial8Params_With7Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value8);
            var fromPartialFunction = arrayFromPartial(value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With6Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value8, value7);
            var fromPartialFunction = arrayFromPartial(value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With5Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value8, value7, value6);
            var fromPartialFunction = arrayFromPartial(value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value8, value7, value6, value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value8, value7, value6, value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value8, value7, value6, value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial8Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromPartial = createArray.Partial(value8, value7, value6, value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial9Params_With8Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8);
            var fromPartialFunction = arrayFromPartial(value9);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With7Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7);
            var fromPartialFunction = arrayFromPartial(value8, value9);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With6Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6);
            var fromPartialFunction = arrayFromPartial(value7, value8, value9);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With5Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5);
            var fromPartialFunction = arrayFromPartial(value6, value7, value8, value9);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5, value6, value7, value8, value9);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5, value6, value7, value8, value9);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5, value6, value7, value8, value9);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5, value6, value7, value8, value9);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial9Params_With8Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value9);
            var fromPartialFunction = arrayFromPartial(value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With7Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value9, value8);
            var fromPartialFunction = arrayFromPartial(value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With6Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value9, value8, value7);
            var fromPartialFunction = arrayFromPartial(value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With5Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value9, value8, value7, value6);
            var fromPartialFunction = arrayFromPartial(value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value9, value8, value7, value6, value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value9, value8, value7, value6, value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value9, value8, value7, value6, value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial9Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromPartial = createArray.Partial(value9, value8, value7, value6, value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial10Params_With9Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9);
            var fromPartialFunction = arrayFromPartial(value10);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With8Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8);
            var fromPartialFunction = arrayFromPartial(value9, value10);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With7Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7);
            var fromPartialFunction = arrayFromPartial(value8, value9, value10);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With6Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6);
            var fromPartialFunction = arrayFromPartial(value7, value8, value9, value10);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With5Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5);
            var fromPartialFunction = arrayFromPartial(value6, value7, value8, value9, value10);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5, value6, value7, value8, value9, value10);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5, value6, value7, value8, value9, value10);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5, value6, value7, value8, value9, value10);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial10Params_With9Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value10);
            var fromPartialFunction = arrayFromPartial(value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With8Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value10, value9);
            var fromPartialFunction = arrayFromPartial(value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With7Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value10, value9, value8);
            var fromPartialFunction = arrayFromPartial(value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With6Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value10, value9, value8, value7);
            var fromPartialFunction = arrayFromPartial(value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With5Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value10, value9, value8, value7, value6);
            var fromPartialFunction = arrayFromPartial(value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value10, value9, value8, value7, value6, value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value10, value9, value8, value7, value6, value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value10, value9, value8, value7, value6, value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial10Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromPartial = createArray.Partial(value10, value9, value8, value7, value6, value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial11Params_With10Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
            var fromPartialFunction = arrayFromPartial(value11);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With9Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9);
            var fromPartialFunction = arrayFromPartial(value10, value11);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With8Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8);
            var fromPartialFunction = arrayFromPartial(value9, value10, value11);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With7Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7);
            var fromPartialFunction = arrayFromPartial(value8, value9, value10, value11);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With6Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6);
            var fromPartialFunction = arrayFromPartial(value7, value8, value9, value10, value11);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With5Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5);
            var fromPartialFunction = arrayFromPartial(value6, value7, value8, value9, value10, value11);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5, value6, value7, value8, value9, value10, value11);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5, value6, value7, value8, value9, value10, value11);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial11Params_With10Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value11);
            var fromPartialFunction = arrayFromPartial(value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With9Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value11, value10);
            var fromPartialFunction = arrayFromPartial(value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With8Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value11, value10, value9);
            var fromPartialFunction = arrayFromPartial(value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With7Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value11, value10, value9, value8);
            var fromPartialFunction = arrayFromPartial(value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With6Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value11, value10, value9, value8, value7);
            var fromPartialFunction = arrayFromPartial(value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With5Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value11, value10, value9, value8, value7, value6);
            var fromPartialFunction = arrayFromPartial(value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value11, value10, value9, value8, value7, value6, value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value11, value10, value9, value8, value7, value6, value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value11, value10, value9, value8, value7, value6, value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial11Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromPartial = createArray.Partial(value11, value10, value9, value8, value7, value6, value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial12Params_With11Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
            var fromPartialFunction = arrayFromPartial(value12);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With10Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
            var fromPartialFunction = arrayFromPartial(value11, value12);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With9Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9);
            var fromPartialFunction = arrayFromPartial(value10, value11, value12);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With8Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8);
            var fromPartialFunction = arrayFromPartial(value9, value10, value11, value12);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With7Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7);
            var fromPartialFunction = arrayFromPartial(value8, value9, value10, value11, value12);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With6Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6);
            var fromPartialFunction = arrayFromPartial(value7, value8, value9, value10, value11, value12);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With5Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5);
            var fromPartialFunction = arrayFromPartial(value6, value7, value8, value9, value10, value11, value12);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5, value6, value7, value8, value9, value10, value11, value12);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial12Params_With11Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value12);
            var fromPartialFunction = arrayFromPartial(value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With10Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value12, value11);
            var fromPartialFunction = arrayFromPartial(value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With9Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value12, value11, value10);
            var fromPartialFunction = arrayFromPartial(value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With8Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value12, value11, value10, value9);
            var fromPartialFunction = arrayFromPartial(value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With7Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value12, value11, value10, value9, value8);
            var fromPartialFunction = arrayFromPartial(value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With6Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value12, value11, value10, value9, value8, value7);
            var fromPartialFunction = arrayFromPartial(value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With5Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value12, value11, value10, value9, value8, value7, value6);
            var fromPartialFunction = arrayFromPartial(value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value12, value11, value10, value9, value8, value7, value6, value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value12, value11, value10, value9, value8, value7, value6, value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value12, value11, value10, value9, value8, value7, value6, value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial12Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromPartial = createArray.Partial(value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial13Params_With12Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
            var fromPartialFunction = arrayFromPartial(value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With11Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
            var fromPartialFunction = arrayFromPartial(value12, value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With10Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
            var fromPartialFunction = arrayFromPartial(value11, value12, value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With9Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9);
            var fromPartialFunction = arrayFromPartial(value10, value11, value12, value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With8Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8);
            var fromPartialFunction = arrayFromPartial(value9, value10, value11, value12, value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With7Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7);
            var fromPartialFunction = arrayFromPartial(value8, value9, value10, value11, value12, value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With6Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6);
            var fromPartialFunction = arrayFromPartial(value7, value8, value9, value10, value11, value12, value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With5Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5);
            var fromPartialFunction = arrayFromPartial(value6, value7, value8, value9, value10, value11, value12, value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial13Params_With12Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13);
            var fromPartialFunction = arrayFromPartial(value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With11Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13, value12);
            var fromPartialFunction = arrayFromPartial(value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With10Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13, value12, value11);
            var fromPartialFunction = arrayFromPartial(value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With9Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13, value12, value11, value10);
            var fromPartialFunction = arrayFromPartial(value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With8Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13, value12, value11, value10, value9);
            var fromPartialFunction = arrayFromPartial(value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With7Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13, value12, value11, value10, value9, value8);
            var fromPartialFunction = arrayFromPartial(value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With6Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13, value12, value11, value10, value9, value8, value7);
            var fromPartialFunction = arrayFromPartial(value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With5Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13, value12, value11, value10, value9, value8, value7, value6);
            var fromPartialFunction = arrayFromPartial(value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13, value12, value11, value10, value9, value8, value7, value6, value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13, value12, value11, value10, value9, value8, value7, value6, value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial13Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromPartial = createArray.Partial(value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial14Params_With13Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
            var fromPartialFunction = arrayFromPartial(value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With12Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
            var fromPartialFunction = arrayFromPartial(value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With11Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
            var fromPartialFunction = arrayFromPartial(value12, value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With10Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
            var fromPartialFunction = arrayFromPartial(value11, value12, value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With9Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9);
            var fromPartialFunction = arrayFromPartial(value10, value11, value12, value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With8Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8);
            var fromPartialFunction = arrayFromPartial(value9, value10, value11, value12, value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With7Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7);
            var fromPartialFunction = arrayFromPartial(value8, value9, value10, value11, value12, value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With6Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6);
            var fromPartialFunction = arrayFromPartial(value7, value8, value9, value10, value11, value12, value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With5Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5);
            var fromPartialFunction = arrayFromPartial(value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial14Params_With13Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14);
            var fromPartialFunction = arrayFromPartial(value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With12Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13);
            var fromPartialFunction = arrayFromPartial(value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With11Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13, value12);
            var fromPartialFunction = arrayFromPartial(value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With10Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13, value12, value11);
            var fromPartialFunction = arrayFromPartial(value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With9Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13, value12, value11, value10);
            var fromPartialFunction = arrayFromPartial(value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With8Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13, value12, value11, value10, value9);
            var fromPartialFunction = arrayFromPartial(value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With7Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13, value12, value11, value10, value9, value8);
            var fromPartialFunction = arrayFromPartial(value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With6Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13, value12, value11, value10, value9, value8, value7);
            var fromPartialFunction = arrayFromPartial(value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With5Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13, value12, value11, value10, value9, value8, value7, value6);
            var fromPartialFunction = arrayFromPartial(value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13, value12, value11, value10, value9, value8, value7, value6, value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial14Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromPartial = createArray.Partial(value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial15Params_With14Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
            var fromPartialFunction = arrayFromPartial(value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With13Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
            var fromPartialFunction = arrayFromPartial(value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With12Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
            var fromPartialFunction = arrayFromPartial(value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With11Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
            var fromPartialFunction = arrayFromPartial(value12, value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With10Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
            var fromPartialFunction = arrayFromPartial(value11, value12, value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With9Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9);
            var fromPartialFunction = arrayFromPartial(value10, value11, value12, value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With8Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8);
            var fromPartialFunction = arrayFromPartial(value9, value10, value11, value12, value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With7Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7);
            var fromPartialFunction = arrayFromPartial(value8, value9, value10, value11, value12, value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With6Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6);
            var fromPartialFunction = arrayFromPartial(value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With5Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5);
            var fromPartialFunction = arrayFromPartial(value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial15Params_With14Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15);
            var fromPartialFunction = arrayFromPartial(value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With13Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14);
            var fromPartialFunction = arrayFromPartial(value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With12Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13);
            var fromPartialFunction = arrayFromPartial(value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With11Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13, value12);
            var fromPartialFunction = arrayFromPartial(value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With10Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13, value12, value11);
            var fromPartialFunction = arrayFromPartial(value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With9Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13, value12, value11, value10);
            var fromPartialFunction = arrayFromPartial(value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With8Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13, value12, value11, value10, value9);
            var fromPartialFunction = arrayFromPartial(value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With7Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13, value12, value11, value10, value9, value8);
            var fromPartialFunction = arrayFromPartial(value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With6Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13, value12, value11, value10, value9, value8, value7);
            var fromPartialFunction = arrayFromPartial(value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With5Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13, value12, value11, value10, value9, value8, value7, value6);
            var fromPartialFunction = arrayFromPartial(value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13, value12, value11, value10, value9, value8, value7, value6, value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial15Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromPartial = createArray.Partial(value15, value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>

		#region With correct Sequence
		
        [Test]
        public void Partial16Params_With15Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
            var fromPartialFunction = arrayFromPartial(value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With14Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
            var fromPartialFunction = arrayFromPartial(value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With13Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
            var fromPartialFunction = arrayFromPartial(value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With12Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
            var fromPartialFunction = arrayFromPartial(value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With11Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
            var fromPartialFunction = arrayFromPartial(value12, value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With10Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
            var fromPartialFunction = arrayFromPartial(value11, value12, value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With9Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8, value9);
            var fromPartialFunction = arrayFromPartial(value10, value11, value12, value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With8Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7, value8);
            var fromPartialFunction = arrayFromPartial(value9, value10, value11, value12, value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With7Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6, value7);
            var fromPartialFunction = arrayFromPartial(value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With6Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5, value6);
            var fromPartialFunction = arrayFromPartial(value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With5Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4, value5);
            var fromPartialFunction = arrayFromPartial(value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With4Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3, value4);
            var fromPartialFunction = arrayFromPartial(value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With3Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2, value3);
            var fromPartialFunction = arrayFromPartial(value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With2Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1, value2);
            var fromPartialFunction = arrayFromPartial(value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With1Input_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value1);
            var fromPartialFunction = arrayFromPartial(value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Assert
            Assert.AreEqual(expected, fromPartialFunction);
        }
		
		#endregion

		#region With reverted Sequence
		
        [Test]
        public void Partial16Params_With15Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16);
            var fromPartialFunction = arrayFromPartial(value15, value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With14Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15);
            var fromPartialFunction = arrayFromPartial(value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With13Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14);
            var fromPartialFunction = arrayFromPartial(value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With12Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13);
            var fromPartialFunction = arrayFromPartial(value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With11Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13, value12);
            var fromPartialFunction = arrayFromPartial(value11, value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With10Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13, value12, value11);
            var fromPartialFunction = arrayFromPartial(value10, value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With9Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13, value12, value11, value10);
            var fromPartialFunction = arrayFromPartial(value9, value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With8Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13, value12, value11, value10, value9);
            var fromPartialFunction = arrayFromPartial(value8, value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With7Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13, value12, value11, value10, value9, value8);
            var fromPartialFunction = arrayFromPartial(value7, value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With6Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13, value12, value11, value10, value9, value8, value7);
            var fromPartialFunction = arrayFromPartial(value6, value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With5Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13, value12, value11, value10, value9, value8, value7, value6);
            var fromPartialFunction = arrayFromPartial(value5, value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With4Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13, value12, value11, value10, value9, value8, value7, value6, value5);
            var fromPartialFunction = arrayFromPartial(value4, value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With3Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4);
            var fromPartialFunction = arrayFromPartial(value3, value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With2Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3);
            var fromPartialFunction = arrayFromPartial(value2, value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
        [Test]
        public void Partial16Params_With1Input_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromPartial = createArray.Partial(value16, value15, value14, value13, value12, value11, value10, value9, value8, value7, value6, value5, value4, value3, value2);
            var fromPartialFunction = arrayFromPartial(value1);

            // Assert
            Assert.AreNotEqual(expected, fromPartialFunction);
            Assert.AreEqual(expected.Reverse(), fromPartialFunction);
        }
		
		#endregion

		#endregion
			
	}
}