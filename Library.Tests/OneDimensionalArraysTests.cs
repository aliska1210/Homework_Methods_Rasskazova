using NUnit.Framework;
using Library;

namespace Library.Tests
{
    class OneDimensionalArraysTests
    {
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 0)]
        [TestCase(new int[7] { 2, 0, 3, 9, 21, 24, 12 }, 0)]
        [TestCase(new int[10] { 9, 54, 35, 78, 32, 90, 11, 16, 76, 87 }, 9)]
        [TestCase(new int[5] { -6, 1, 2, 3, 4 }, -6)]
        public void FindMinimumElementOfArrayTest(int[] Array, int expected)
        {
            int actual = Library.OneDimensionalArrays.FindMinimumElementOfArray(Array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 4)]
        [TestCase(new int[7] { 2, 0, 3, 9, 21, 24, 12 }, 24)]
        [TestCase(new int[10] { 9, 54, 35, 78, 32, 90, 11, 16, 76, 87 }, 90)]
        [TestCase(new int[5] { -6, -1, -20, -35, -34 }, -1)]
        public void FindMaximumElementOfArrayTest(int[] Array, int expected)
        {
            int actual = Library.OneDimensionalArrays.FindMaximumElementOfArray(Array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 4, 4)]
        [TestCase(new int[7] { 2, 0, 3, 9, 21, 24, 12 }, 2, 0)]
        [TestCase(new int[10] { 9, 54, 35, 78, 32, 90, 11, 16, 76, 87 }, 90, 5)]
        [TestCase(new int[5] { -6, -1, -20, -35, -34 }, -1, 1)]
        public void FindIndexOfElementOfArrayTest(int[] Array, int Element, int expected)
        {
            int actual = Library.OneDimensionalArrays.FindIndexOfElementOfArray(Array, Element);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 4)]
        [TestCase(new int[7] { 2, 0, 3, 9, 21, 24, 12 }, 33)]
        [TestCase(new int[10] { 9, 54, 35, 78, 32, 90, 11, 16, 76, 87 }, 325)]
        [TestCase(new int[5] { -6, -1, -20, -35, -34 }, -36)]
        public void SolveTask5Test(int[] Array, int expected)
        {
            int actual = Library.OneDimensionalArrays.SolveTask5(Array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, new int[5] { 4, 3, 2, 1, 0 })]
        [TestCase(new int[7] { 2, 0, 3, 9, 21, 24, 12 }, new int[7] {12,24,21,9,3,0,2})]
        [TestCase(new int[10] { 9, 54, 35, 78, 32, 90, 11, 16, 76, 87 }, new int[10] { 87, 76,16,11,90,32,78,35,54,9})]
        [TestCase(new int[5] { -6, -1, -20, -35, -34 }, new int[5] { -34, -35, -20,-1,-6})]
        public void ReverseOneDimensionalArrayTest(int[] Array, int[] expected)
        {
            int[] actual = Library.OneDimensionalArrays.ReverseOneDimensionalArray(Array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 2)]
        [TestCase(new int[7] { 2, 0, 3, 9, 21, 24, 12 }, 3)]
        [TestCase(new int[10] { 9, 54, 35, 78, 32, 90, 11, 16, 76, 87 }, 4)]
        [TestCase(new int[5] { -6, -1, -20, -35, -34 }, 2)]
        public void SolveTask7Test(int[] Array, int expected)
        {
            int actual = Library.OneDimensionalArrays.SolveTask7(Array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[6] { 2, 0, 3, 9, 21, 24 }, new int[6] { 9, 21, 24, 2, 0, 3 })]
        [TestCase(new int[10] { 9, 54, 35, 78, 32, 90, 11, 16, 76, 87 }, new int[10] { 90, 11, 16, 76, 87, 9, 54, 35, 78, 32 })]
        [TestCase(new int[4] { -6, -1, -20, -35 }, new int[4] { -20, -35, -6, -1 })]
        public void SolveTask8Test(int[] Array, int[] expected)
        {
            int[] actual = Library.OneDimensionalArrays.SolveTask8(Array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 0, 1, 2, 3,4 }, new int[5] { 0, 1, 2, 3, 4 })]
        [TestCase(new int[7] { 2, 0, 3, 9, 21, 24, 12 }, new int[7] { 0, 2, 3, 9, 12,21, 24 })]
        [TestCase(new int[10] { 9, 54, 35, 78, 32, 90, 11, 16, 76, 87 }, new int[10] { 9, 11, 16, 32, 35, 54, 76, 78, 87, 90 })]
        [TestCase(new int[5] { -6, -1, -20, -35, -34 }, new int[5] { -35, -34, -20, -6, -1 })]
        public void SortMinimumToMaximumTest(int[] Array, int[] expected)
        {
            int[] actual = Library.OneDimensionalArrays.SortMinimumToMaximum(Array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, new int[5] { 4, 3, 2, 1, 0 })]
        [TestCase(new int[7] { 2, 0, 3, 9, 21, 24, 12 }, new int[7] { 24, 21, 12, 9, 3, 2, 0 })]
        [TestCase(new int[10] { 9, 54, 35, 78, 32, 90, 11, 16, 76, 87 }, new int[10] { 90, 87, 78, 76, 54, 35, 32, 16, 11, 9 })]
        [TestCase(new int[5] { -6, -1, -20, -35, -34 }, new int[5] { -1, -6, -20, -34, -35 })]
        public void SortMaximumToMinimumTest(int[] Array, int[] expected)
        {
            int[] actual = Library.OneDimensionalArrays.SortMaximumToMinimum(Array);
            Assert.AreEqual(expected, actual);
        }


    }
}
