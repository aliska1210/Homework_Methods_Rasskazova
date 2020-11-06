using System;

namespace Library
{
    public class Variables
    {
        public static int SolveTask1 (int a, int b)
        {
            return (5 *a + b * b) / (b - a);
        }

        public static int[] SwapTwoVariables(int a, int b)
        {
            int[] Swap = new int[2];
            Swap[0] = b;
            Swap[1] = a;
            return Swap;
        }

        public static int Division(int a, int b)
        {
            return a/b;
        }
        public static int RemainderOfDivision(int a, int b)
        {
            return a%b;
        }

        public static double SolveTask4 (int a, int b, int c)
        {
            return ((double)c - (double)b) / (double)a;
        }

        public static double[] SolveTask5(int x1, int y1, int x2, int y2)
        {
            double[] Сoefficients = new double[2];
            Сoefficients[0] = (double)(y1 - y2) / (double)(x1 - x2);
            Сoefficients[1] = (double)y2 - Сoefficients[0] * (double)x2;
            return Сoefficients;
        }
    }
}
