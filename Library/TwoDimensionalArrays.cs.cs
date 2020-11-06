using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public static class TwoDimensionalArrays
    {
        public static int FindMinimumElementOfArray(int[,] Array)
        {
            int MinimunElement = 100;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (MinimunElement >= Array[i, j])
                    {
                        MinimunElement = Array[i, j];
                    }
                }
            }

            return MinimunElement;
        }

        public static int FindMaximumElementOfArray(int[,] Array)
        {
            int MaximumElement = 0;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (MaximumElement <= Array[i, j])
                    {
                        MaximumElement = Array[i, j];
                    }
                }
            }

            return MaximumElement;
        }

        public static int[] FindIndexOfElementOfArray(int[,] Array, int Element)
        {
            int IndexOfElementOfArrayI = 10;
            int IndexOfElementOfArrayJ = 10;

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[i, j] == Element)
                    {
                        IndexOfElementOfArrayI = i;
                        IndexOfElementOfArrayJ = j;
                    }
                }
            }
            int[] IndexesOfElements = new int[2] { IndexOfElementOfArrayI, IndexOfElementOfArrayJ };

            return IndexesOfElements;
        }

        public static int SolveTask5(int[,] Array)
        {
            int[,] ChangedArray = new int[Array.GetLength(0)+1,Array.GetLength(1)+1];

            for (int i = 0; i <= ChangedArray.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= ChangedArray.GetLength(1) - 1; j++)
                {
                    if (i == 0 || i == ChangedArray.GetLength(0) - 1 || j == 0 || j == ChangedArray.GetLength(1) - 1)
                    {
                        ChangedArray[i, j] = 0;
                    }
                    else
                    {
                        ChangedArray[i, j] = Array[i - 1, j - 1];
                    }
                }
            }


            int count = 0;
            for (int i = 1; i < ChangedArray.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < ChangedArray.GetLength(1) - 1; j++)
                {
                    if (ChangedArray[i, j] > ChangedArray[i, j - 1] && ChangedArray[i, j] > ChangedArray[i, j + 1] && ChangedArray[i, j] > ChangedArray[i + 1, j] && ChangedArray[i, j] > ChangedArray[i - 1, j])
                    {
                        count++;
                    }

                }
            }
            return count;
        }

        public static int[,] TransposeMatrix(int[,] Array)
        {
            int[,] ChangedArray = new int[Array.GetLength(0), Array.GetLength(1)];

            for (int i = 0; i < ChangedArray.GetLength(0); i++)
            {
                for (int j = 0; j < ChangedArray.GetLength(1); j++)
                {
                    ChangedArray[i, j] = Array[i,j];
                }
            }

            for (int i = 1; i < ChangedArray.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int tmp = ChangedArray[i, j];
                    ChangedArray[i, j] = ChangedArray[j, i];
                    ChangedArray[j, i] = tmp;
                }
            }
            return ChangedArray;
        }
    }
}

