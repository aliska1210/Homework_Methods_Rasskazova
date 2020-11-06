using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public static class OneDimensionalArrays
    {
        public static int FindMinimumElementOfArray(int[] Array)
        {
            int MinimumElement = 100;
            for (int i = 0; i < Array.Length; i++)
            {
                if (MinimumElement >= Array[i])
                {
                    MinimumElement = Array[i];
                }
            }
            return MinimumElement;
        }

        public static int FindMaximumElementOfArray(int[] Array)
        {
            int MaximumElement = -100;
            for (int i = 0; i < Array.Length; i++)
            {
                if (MaximumElement <= Array[i])
                {
                    MaximumElement = Array[i];
                }
            }
            return MaximumElement;
        }

        public static int FindIndexOfElementOfArray(int[] Array, int Element)
        {
            int IndexOfElementOfArray = Array.Length;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == Element)
                {
                    IndexOfElementOfArray = i;
                }

            }
            return IndexOfElementOfArray;
        }

        public static int SolveTask5(int[] Array)
        {
            int Sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Sum = Sum + Array[i];
                }
            }

            return Sum;
        }

        public static int[] ReverseOneDimensionalArray(int[] Array)
        {
            int[] СhangedArray = new int[Array.Length];
            for (int i = 0; i <= Array.Length - 1; i++)
            {
                СhangedArray[i] = Array[i];
            }

            int tmp = 0;

            for (int i = 0; i < СhangedArray.Length / 2; i++)
            {
                tmp = СhangedArray[i];
                СhangedArray[i] = СhangedArray[СhangedArray.Length - 1 - i];
                СhangedArray[СhangedArray.Length - 1 - i] = tmp;
            }
            return СhangedArray;
        }

        public static int SolveTask7(int[] Array)
        {
            int count = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int[] SolveTask8(int[] Array)
        {
            int[] СhangedArray = new int[Array.Length];
            if (Array.Length%2==0)
            {
                for (int i = 0; i < СhangedArray.Length / 2; i++)
                {
                    СhangedArray[i] = Array[(Array.Length / 2) + i];
                    СhangedArray[СhangedArray.Length / 2 + i] = Array[i];
                }
            }
            return СhangedArray;
        }

        public static int[] SortMinimumToMaximum(int[] Array)
        {
            int tmp = 0;
            int[] СhangedArray = new int[Array.Length];
            for (int i = 0; i <= Array.Length-1; i++)
            {
                СhangedArray[i] = Array[i];
            }

            for (int i = 0; i <= СhangedArray.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i; j <= СhangedArray.Length-1; j++)
                {
                    if (СhangedArray[j] < СhangedArray[minIndex])
                    {
                        minIndex = j;
                    }

                }
                tmp = СhangedArray[i];
                СhangedArray[i] = СhangedArray[minIndex];
                СhangedArray[minIndex] = tmp;
            }
            return СhangedArray;
        }

        public static int[] SortMaximumToMinimum(int[] Array)
        {
            int tmp = 0;
            int[] СhangedArray = new int[Array.Length];
            for (int i = 0; i <= Array.Length - 1; i++)
            {
                СhangedArray[i] = Array[i];
            }

            for (int i = 0; i < СhangedArray.Length-1; i++)
            {
                for (int j = 1; j <= СhangedArray.Length-1; j++)
                {
                    if (СhangedArray[j] > СhangedArray[j - 1])
                    {
                        tmp = СhangedArray[j - 1];
                        СhangedArray[j - 1] = СhangedArray[j];
                        СhangedArray[j] = tmp;
                    }
                }
            }
            return СhangedArray;
        }
    }
}
