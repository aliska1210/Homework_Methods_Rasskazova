using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public static class Cycles
    {
        public static int Exponentiation(int a, int b)
        {
            int c = a;
            for (int i = 1; i < b; i++)
            {
                c *= a;
            }
            return c;
        }

        public static int[] SolveTask2(int a)
        {
            int count = 0;
            int[] Results = new int[1000/a];
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    Results[count] = i;
                    count++;
                }
            }
            return Results;
        }

        public static int SolveTask3(int a)
        {
            int c = 0;
            for (int i = 1; i < a; i++)
            {
                if (i * i < a)
                {
                    c++;
                }
            }
            return c;
        }

        public static int FindLargestDivisor(int a)
        {
            int  c = 0;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    int d = a / i;
                    if (d > c)
                    {
                        c = d;
                    }
                }
            }
            return c;
        }

        public static int SolveTask5(int a, int b)
        {
            int c = 0;
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
            }
            c = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    c += i;
                }
            }
            return c;
        }

        public static int SolveTask6(int a)
        {
            int b = 0;
            int c = 1;
            int fib = 0;
            for (int i = 1; i < a; i++)
            {
                fib = b + c;
                b = c;
                c = fib;
            }

            return fib;
        }

        public static int SolveTask7(int a, int b)
        {
            int c = 0;
            if (a < b)
            {
                c = a;
                a = b;
                b = c;
            }

            while (a % b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return b;
        }

        public static int SolveTask8(int b)
        {
            double IsCube = Math.Pow(b,3);
            if(IsCube%1>0)
            {
                return 0;
            }
            int c = b;
            int a = 0;
            while (((a + b) / 2) * ((a + b) / 2) * ((a + b) / 2) != c)
            {
                if (((a + b) / 2) * ((a + b) / 2) * ((a + b) / 2) < c)
                {
                    a = b / 2;
                }
                else
                {
                    b = b / 2;
                }
            }
            return (a + b) / 2;
        }

        public static int SolveTask9(int a)
        {
            int count = 0;
            while (a != 0)
            {
                int b = a % 10;
                if (b % 2 != 0)
                {
                    count++;
                }
                a = a / 10;
            }
            return count;
        }

        public static int ReverseNumbers(int a)
        {
            int b = 0;
            int c = 0;
            while (a > 0)
            {
                b = b * 10 + a % 10;
                a = a / 10;
            }
            return b;
        }

        public static int SolveTask11(int a)
        {
            int b = 0;
            int c = 0;
            int count = 0;

            for (int i = 1; i <= a; i++)
            {
                b = 0;
                c = 0;
                int d = i % 10;
                int e = i;
                while (e > 0)
                {
                    if (d % 2 == 0)
                    {
                        b = b + d;
                    }
                    else
                    {
                        c = c + d;
                    }
                    e = e / 10;
                }
                if (b > c)
                {
                    count++;
                }
            }
            return count;
        }

        public static int SolveTask12(int a, int b)
        {
            int c = b;
            int count = 0;
            while (a > 0)
            {
                while (b > 0)
                {
                    if (a % 10 == b % 10)
                    {
                        count++;
                    }
                    b /= 10;
                }
                a /= 10;
                b = c;
            }
            return count;

        }
    }
}
