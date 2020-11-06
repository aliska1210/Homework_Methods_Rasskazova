using NUnit.Framework;
using Library;

namespace Library.Tests
{
    public class VariablesTests
    {
        [TestCase(5, 7, 37)]
        [TestCase(8, 2, -7)]
        [TestCase(10, 5, -15)]
        public void SolveTask1Test(int a, int b, int expected)
        {
            int actual = Library.Variables.SolveTask1(a,b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10,10)]
        [TestCase(5, 5)]
        [TestCase(0, 0)]
        public void SolveTask1NegativeTest(int a, int b)
        {
            try
            {
                Library.Variables.SolveTask1(a, b);
            }

            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(3, 4, new int[2] {4, 3})]
        [TestCase(-7, 0, new int[2] { 0, -7 })]
        [TestCase(4, 4, new int[2] { 4, 4 })]
        public void SwapTwoVariablesTest(int a, int b, int[] expected)
        {
            int[] actual = Library.Variables.SwapTwoVariables(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10,2,5)]
        [TestCase(24, 3, 8)]
        [TestCase(25, 2, 12)]
        public void DivisionTest(int a, int b, int expected)
        {
            int actual = Library.Variables.Division(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 2, 1)]
        [TestCase(10, 4, 2)]
        [TestCase(-100, 28, -16)]
        public void RemainderOfDivisionTest(int a, int b, int expected)
        {
            int actual = Library.Variables.RemainderOfDivision(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 8, 2, -2)]
        [TestCase(9, 16, 7, -1)]
        [TestCase(12, 4, 34, 2.5)]
        public void SolveTask4Test(int a, int b, int c, double expected)
        {
            double actual = Library.Variables.SolveTask4(a, b,c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(4, 5, 8, 9, new double[2] { 1, 1 })]
        [TestCase(-3, -16, 5, 13, new double[2] { 3.625, -5.125 })]
        [TestCase(1,2,3,4, new double[2] { 1, 1 })]
        public static void SolveTask5Test(int x1, int y1, int x2, int y2, double[] expected)
        {
            double[] actual = Library.Variables.SolveTask5(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

    }
}