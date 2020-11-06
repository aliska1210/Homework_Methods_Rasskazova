using NUnit.Framework;
using Library;

namespace Library.Tests
{
    class ConditionalConstructionsTests
    {
        [TestCase(5, 2, 7)]
        [TestCase(5, 5, 25)]
        [TestCase(2, 5, -3)]
        public void SolveTask1Test(int a, int b, int expected)
        {
            int actual = Library.ConditionalConstructions.SolveTask1(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 2, "Точка находится в 1 координатной четверти.")]
        [TestCase(-5, 2, "Точка находится во 2 координатной четверти.")]
        [TestCase(-5, -2, "Точка находится в 3 координатной четверти.")]
        [TestCase(5, -2, "Точка находится во 4 координатной четверти.")]
        public void SolveTask2Test(int x, int y, string expected)
        {
            string actual = Library.ConditionalConstructions.SolveTask2(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 2, 4, new int[3] {2,4,5})]
        [TestCase(4, 5, 2, new int[3] { 2, 4, 5 })]
        [TestCase(2, 5, 4, new int[3] { 2, 4, 5 })]
        public void SolveTask3Test(int a, int b, int c, int[] expected)
        {
            int[] actual = Library.ConditionalConstructions.SolveTask3(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 3, 5, new double[2] {0, 0})]
        [TestCase(1, -4, 4, new double[2] { 2, 0 })]
        [TestCase(2, 5, -7, new double[2] { -3.5, 1 })]
        public void SolveQuadraticEquationTest(int a, int b, int c, double[] expected)
        {
            double[] actual = Library.ConditionalConstructions.SolveQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new string[2] { "Вы ввели число меньше 10.", "" })]
        [TestCase(11, new string[2] { "Одиннадцать.", "" })]
        [TestCase(45, new string[2] { "Сорок ", "пять." })]
        public void SolveTask5Test(int a,  string[] expected)
        {
            string[] actual = Library.ConditionalConstructions.SolveTask5(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
