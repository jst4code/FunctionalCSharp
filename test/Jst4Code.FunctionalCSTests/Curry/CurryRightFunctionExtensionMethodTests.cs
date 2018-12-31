using Jst4Code.FunctionalCS;
using System;
using System.Linq;
using NUnit.Framework;

namespace Jst4Code.FunctionalCSTests.Curry
{
	public class CurryRightFunctionExtensionMethodTests
	{
        [Test]
        public void Curry2Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2;

            Func<int, int, int[]> createArray = (in1, in2) => new int[] { in1, in2 };
            var expected = createArray(value1, value2);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry2Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2;

            Func<int, int, int[]> createArray = (in1, in2) => new int[] { in1, in2 };
            var expected = createArray(value1, value2);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry3Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3;

            Func<int, int, int, int[]> createArray = (in1, in2, in3) => new int[] { in1, in2, in3 };
            var expected = createArray(value1, value2, value3);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry3Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3;

            Func<int, int, int, int[]> createArray = (in1, in2, in3) => new int[] { in1, in2, in3 };
            var expected = createArray(value1, value2, value3);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry4Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4;

            Func<int, int, int, int, int[]> createArray = (in1, in2, in3, in4) => new int[] { in1, in2, in3, in4 };
            var expected = createArray(value1, value2, value3, value4);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry4Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4;

            Func<int, int, int, int, int[]> createArray = (in1, in2, in3, in4) => new int[] { in1, in2, in3, in4 };
            var expected = createArray(value1, value2, value3, value4);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry5Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;

            Func<int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5) => new int[] { in1, in2, in3, in4, in5 };
            var expected = createArray(value1, value2, value3, value4, value5);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry5Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;

            Func<int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5) => new int[] { in1, in2, in3, in4, in5 };
            var expected = createArray(value1, value2, value3, value4, value5);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry6Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value6)(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry6Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;

            Func<int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6) => new int[] { in1, in2, in3, in4, in5, in6 };
            var expected = createArray(value1, value2, value3, value4, value5, value6);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry7Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value7)(value6)(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry7Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;

            Func<int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7) => new int[] { in1, in2, in3, in4, in5, in6, in7 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry8Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry8Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;

            Func<int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry9Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry9Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;

            Func<int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry10Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry10Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;

            Func<int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry11Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry11Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;

            Func<int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry12Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value12)(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry12Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11)(value12);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry13Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value13)(value12)(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry13Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11)(value12)(value13);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry14Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value14)(value13)(value12)(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry14Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11)(value12)(value13)(value14);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry15Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value15)(value14)(value13)(value12)(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry15Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11)(value12)(value13)(value14)(value15);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	
        [Test]
        public void Curry16Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value16)(value15)(value14)(value13)(value12)(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);

            // Assert
            Assert.AreEqual(expected, fromCurriedFunction);
        }

        [Test]
        public void Curry16Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;

            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int[]> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            var expected = createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

            // Act
            var arrayFromCurry = createArray.CurryRight();
            var fromCurriedFunction = arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11)(value12)(value13)(value14)(value15)(value16);

            // Assert
            Assert.AreNotEqual(expected, fromCurriedFunction);
            Assert.AreEqual(expected, fromCurriedFunction.Reverse());
        }
	}
}