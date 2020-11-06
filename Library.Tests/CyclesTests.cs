using NUnit.Framework;
using Library;

namespace Library.Tests
{
    class CyclesTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(8, 5, 32768)]
        [TestCase(2, 3, 8)]
        public void ExponentiationTest(int a, int b, int expected)
        {
            int actual = Library.Cycles.Exponentiation(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, new int[10] {100,200,300,400,500,600,700,800,900,1000})]
        [TestCase(500, new int[2] { 500, 1000 })]
        [TestCase(250, new int[4] { 250, 500, 750, 1000 })]
        public void SolveTask2Test(int a, int[] expected)
        {
            int[] actual = Library.Cycles.SolveTask2(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 3)]
        [TestCase(100, 9)]
        [TestCase(150, 12)]
        public void SolveTask3Test(int a, int expected)
        {
            int actual = Library.Cycles.SolveTask3(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(180, 90)]
        [TestCase(90, 45)]
        [TestCase(10, 5)]
        public void FindLargestDivisorTest(int a, int expected)
        {
            int actual = Library.Cycles.FindLargestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 21, 42)]
        [TestCase(5, 10, 7)]
        [TestCase(11, 12, 0)]
        public void SolveTask5Test(int a, int b, int expected)
        {
            int actual = Library.Cycles.SolveTask5(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 144)]
        [TestCase(5, 5)]
        [TestCase(2, 1)]
        public void SolveTask6Test(int a, int expected)
        {
            int actual = Library.Cycles.SolveTask6(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(16, 138, 2)]
        [TestCase(200, 50, 50)]
        [TestCase(12, 6, 6)]
        public void SolveTask7Test(int a, int b, int expected)
        {
            int actual = Library.Cycles.SolveTask7(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 2)]
        [TestCase(27, 3)]
        [TestCase(343, 7)]
        public void SolveTask8Test(int b, int expected)
        {
            int actual = Library.Cycles.SolveTask8(b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 0)]
        [TestCase(27644, 1)]
        [TestCase(343, 2)]
        public void SolveTask9Test(int a, int expected)
        {
            int actual = Library.Cycles.SolveTask9(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 8)]
        [TestCase(27644, 44672)]
        [TestCase(343, 343)]
        public void ReverseNumbers8Test(int a, int expected)
        {
            int actual = Library.Cycles.ReverseNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 1)]
        [TestCase(15, 6)]
        [TestCase(10, 4)]
        public void SolveTask11Test(int a, int expected)
        {
            int actual = Library.Cycles.SolveTask11(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2547, 74528, 4)]
        [TestCase(124, 785, 0)]
        [TestCase(1234, 3456, 2)]
        public void SolveTask12Test(int a, int b, int expected)
        {
            int actual = Library.Cycles.SolveTask12(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}
