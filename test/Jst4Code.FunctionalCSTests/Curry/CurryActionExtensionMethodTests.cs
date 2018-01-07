using Jst4Code.FunctionalCS;
using System;
using System.Linq;
using Xunit;

namespace Jst4Code.FunctionalCSTests.Curry
{
	public class CurryActionExtensionMethodTests
	{
        [Fact]
        public void Curry2Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2;
            int[] collection = null;

            Action<int, int> createArray = (in1, in2) => collection = new int[] { in1, in2 };
            createArray(value1, value2);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry2Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2;
            int[] collection = null;

            Action<int, int> createArray = (in1, in2) => collection = new int[] { in1, in2 };
            createArray(value1, value2);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry3Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3;
            int[] collection = null;

            Action<int, int, int> createArray = (in1, in2, in3) => collection = new int[] { in1, in2, in3 };
            createArray(value1, value2, value3);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry3Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3;
            int[] collection = null;

            Action<int, int, int> createArray = (in1, in2, in3) => collection = new int[] { in1, in2, in3 };
            createArray(value1, value2, value3);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry4Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4;
            int[] collection = null;

            Action<int, int, int, int> createArray = (in1, in2, in3, in4) => collection = new int[] { in1, in2, in3, in4 };
            createArray(value1, value2, value3, value4);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry4Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4;
            int[] collection = null;

            Action<int, int, int, int> createArray = (in1, in2, in3, in4) => collection = new int[] { in1, in2, in3, in4 };
            createArray(value1, value2, value3, value4);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry5Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;
            int[] collection = null;

            Action<int, int, int, int, int> createArray = (in1, in2, in3, in4, in5) => collection = new int[] { in1, in2, in3, in4, in5 };
            createArray(value1, value2, value3, value4, value5);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry5Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5;
            int[] collection = null;

            Action<int, int, int, int, int> createArray = (in1, in2, in3, in4, in5) => collection = new int[] { in1, in2, in3, in4, in5 };
            createArray(value1, value2, value3, value4, value5);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry6Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;
            int[] collection = null;

            Action<int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6) => collection = new int[] { in1, in2, in3, in4, in5, in6 };
            createArray(value1, value2, value3, value4, value5, value6);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry6Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6;
            int[] collection = null;

            Action<int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6) => collection = new int[] { in1, in2, in3, in4, in5, in6 };
            createArray(value1, value2, value3, value4, value5, value6);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value6)(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry7Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;
            int[] collection = null;

            Action<int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7 };
            createArray(value1, value2, value3, value4, value5, value6, value7);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry7Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7;
            int[] collection = null;

            Action<int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7 };
            createArray(value1, value2, value3, value4, value5, value6, value7);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value7)(value6)(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry8Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry8Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry9Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry9Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry10Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry10Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry11Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry11Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry12Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11)(value12);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry12Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value12)(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry13Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11)(value12)(value13);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry13Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value13)(value12)(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry14Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11)(value12)(value13)(value14);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry14Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value14)(value13)(value12)(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry15Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11)(value12)(value13)(value14)(value15);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry15Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value15)(value14)(value13)(value12)(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	
        [Fact]
        public void Curry16Params_Should_Match()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value1)(value2)(value3)(value4)(value5)(value6)(value7)(value8)(value9)(value10)(value11)(value12)(value13)(value14)(value15)(value16);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.Equal(expectedCollection, actualCollection);
        }

        [Fact]
        public void Curry16Params_Should_Not_Match_When_Sequence_Changed()
        {
            // Arrange
            int value1 = 1, value2 = 2, value3 = 3, value4 = 4, value5 = 5, value6 = 6, value7 = 7, value8 = 8, value9 = 9, value10 = 10, value11 = 11, value12 = 12, value13 = 13, value14 = 14, value15 = 15, value16 = 16;
            int[] collection = null;

            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> createArray = (in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16) => collection = new int[] { in1, in2, in3, in4, in5, in6, in7, in8, in9, in10, in11, in12, in13, in14, in15, in16 };
            createArray(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
            var expectedCollection = collection;
            collection = null;

            // Act
            var arrayFromCurry = createArray.Curry();
            arrayFromCurry(value16)(value15)(value14)(value13)(value12)(value11)(value10)(value9)(value8)(value7)(value6)(value5)(value4)(value3)(value2)(value1);
            var actualCollection = collection;

            // Assert
            Assert.False(expectedCollection == actualCollection);
            Assert.NotEqual(expectedCollection, actualCollection);
            Assert.Equal(expectedCollection, actualCollection.Reverse());
        }
	}
}