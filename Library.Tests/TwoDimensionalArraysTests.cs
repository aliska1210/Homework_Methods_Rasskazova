using NUnit.Framework;
using Library;
namespace Library.Tests
{
    class TwoDimensionalArraysTests
    {
        int[,] ArrayMock;
        int[,] ExpectedMock;

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void FindMinimumElementOfArrayTest(int n, int expected)
        {
            SetMock(n);
            int actual = Library.TwoDimensionalArrays.FindMinimumElementOfArray(ArrayMock);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 9)]
        [TestCase(2, 24)]
        public void FindMaximumElementOfArrayTest(int n, int expected)
        {
            SetMock(n);
            int actual = Library.TwoDimensionalArrays.FindMaximumElementOfArray(ArrayMock);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 3, new int[2] {0 , 2})]
        [TestCase(2, 12, new int[2] {2 ,2 })]
        public void FindIndexOfElementOfArrayTest(int n, int Element, int[] expected)
        {
            SetMock(n);
            int[] actual = Library.TwoDimensionalArrays.FindIndexOfElementOfArray(ArrayMock, Element);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        public void SolveTask5Test(int n, int expected)
        {
            SetMock(n);
            int actual = Library.TwoDimensionalArrays.SolveTask5(ArrayMock);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1,1)]
        [TestCase(2,2)]
        public void TransposeMatrixTest(int n, int m)
        {
            SetMock(n);
            SetExpectedMock(m);

            int[,] expected = ExpectedMock;
            int[,] actual = Library.TwoDimensionalArrays.TransposeMatrix(ArrayMock);
            Assert.AreEqual(expected, actual);
        }


        void SetMock(int n)
        {
            switch(n)
            {
                case 1:
                    ArrayMock = new int[,]
                    {
                        {1,2,3},
                        {4,5,6},
                        {7,8,9}
                    };
                    break;

                case 2:
                    ArrayMock = new int[,]
                    {
                        {1,2,3,4,5},
                        {6,7,8,9,10},
                        {10,11,12,13,14},
                        {15,16,17,18,19},
                        {20,21,22,23,24}
                    };
                    break;
            }
        }
        void SetExpectedMock(int n)
        {
            switch (n)
            {
                case 1:
                    ExpectedMock = new int[,]
                    {
                        {1,4,7},
                        {2,5,8},
                        {3,6,9}
                    };
                    break;

                case 2:
                    ExpectedMock = new int[,]
                    {
                        {1,6,10,15,20},
                        {2,7,11,16,21},
                        {3,8,12,17,22},
                        {4,9,13,18,23},
                        {5,10,14,19,24}
                    };
                    break;
            }
        }

    }
}
