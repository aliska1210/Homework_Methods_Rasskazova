using System;
using Library;

namespace Homework_Methods_Rasskazova
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int x1, x2, y1, y2;
            double[] Сoefficients = new double[2];
            double[] Results = new double[2];
            string[] IsNumber = new string[2];
            int[] Numbers = new int[2];

            Console.WriteLine("Тема переменные");
            Console.WriteLine("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n\n Задача 1.");
            Console.WriteLine($"Ответ: {Library.Variables.SolveTask1(a, b)}");

            Console.WriteLine("\n\n Задача 2.");
            int[] Swap = new int[2];
            Swap = Library.Variables.SwapTwoVariables(a, b);
            Console.WriteLine($"Мы поменяли значения, и теперь А = {Swap[0]}, B = {Swap[1]}");

            Console.WriteLine("\n\n Задача 3.");

            Console.WriteLine($"Число А ({a}) делится на В ({b}) {Library.Variables.Division(a, b)} раз.");
            Console.WriteLine($"Остаток от деления А на B равен {Library.Variables.RemainderOfDivision(a, b)}.");

            Console.WriteLine("\n\n Задача 4.");

            Console.WriteLine("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение C: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"В линейном уравнении стандартного вида, где A*X+B=C, значение X = {Library.Variables.SolveTask4(a,b,c)}");

            Console.WriteLine("\n\n Задача 5.");
            Console.WriteLine("Введите значение X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            Сoefficients = Library.Variables.SolveTask5(x1,y1,x2,y2);
            Console.WriteLine($"Уравнение прямой в формате Y=AX+B, проходящей через эти точки: Y = {Сoefficients[0]}X + {Сoefficients[1]}"); 

            Console.WriteLine("\n\nТема структуры ветвления");
            Console.WriteLine("\n\n Задача 1.");
            Console.WriteLine("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ответ: {Library.ConditionalConstructions.SolveTask1(a, b)}");


            Console.WriteLine("\n\n Задача 2.");
            Console.WriteLine("Введите значение X: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Library.ConditionalConstructions.SolveTask2(a,b));

            Console.WriteLine("\n\n Задача 3.");
            Console.WriteLine("Введите значение A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение C: ");
            c = Convert.ToInt32(Console.ReadLine());
            Numbers = Library.ConditionalConstructions.SolveTask3(a, b, c);
            Console.WriteLine($"Числа в порядке позрастания: {Numbers[0]} {Numbers[1]} {Numbers[2]}");

            Console.WriteLine("\n Задача 4.");
            Console.WriteLine("Введите значение A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение C: ");
            c = Convert.ToInt32(Console.ReadLine());
            Results = Library.ConditionalConstructions.SolveQuadraticEquation(a,b,c);
            Console.WriteLine($"Решение квадратного  стандартного вида, где AX2+BX+C=0: {Results[0]} {Results[1]}");

            Console.WriteLine("\n Задача 5.");
            Console.WriteLine("Введите любое двухзначное число: ");
            a = Convert.ToInt32(Console.ReadLine());
            IsNumber = Library.ConditionalConstructions.SolveTask5(a);
            Console.WriteLine($"Вы ввели число: {IsNumber[0]}{IsNumber[1]}");

            Console.WriteLine("\n\nТема Циклы");
            Console.WriteLine("\nЗадача 1.");
            Console.WriteLine("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение В: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число A в степени В = {Library.Cycles.Exponentiation(a,b)}");
           

            Console.WriteLine("\nЗадача 2.");
            Console.WriteLine("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            int[] ResultsCyclesSolveTask2 = new int[1000/a];
            ResultsCyclesSolveTask2 = Library.Cycles.SolveTask2(a);
            for (int i = 0; i <=ResultsCyclesSolveTask2.Length-1; i++)
            {
                Console.Write($"{ResultsCyclesSolveTask2[i]} ");
            }

            Console.WriteLine("\nЗадача 3.");
            Console.WriteLine("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Количество положительных целых чисел, квадрат которых меньше A = {Library.Cycles.SolveTask3(a)} ");

            Console.WriteLine("\nЗадача 4.");
            Console.WriteLine("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Наибольший делитель числа A: {Library.Cycles.FindLargestDivisor(a)} ");
            

            Console.WriteLine("\nЗадача 5.");
            Console.WriteLine("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Cумма чисел в диапозоне от {a} до {b}, делящихся на 7 равна: {Library.Cycles.SolveTask5(a,b)} ");

            Console.WriteLine("\nЗадача 6.");
            Console.WriteLine("Укажите число N: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число под номером {a} в ряду Фибоначчи: {Library.Cycles.SolveTask6(a)}");
            

            Console.WriteLine("\nЗадача 7.");
            Console.WriteLine("Укажите число А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите число B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Наибольший общий делитель чисел А и В: {Library.Cycles.SolveTask7(a, b)} ");

            Console.WriteLine("\nЗадача 8.");
            Console.WriteLine("Укажите куб числа N: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Кубический корень указанного числа: {Library.Cycles.SolveTask8(b)}");

            Console.WriteLine("\nЗадача 9.");
            Console.WriteLine("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество нечетных цифр в заданном числе: {Library.Cycles.SolveTask9(a)}");
           
            
            Console.WriteLine("\nЗадача 10.");
            Console.WriteLine("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Реверс числа: {Library.Cycles.ReverseNumbers(a)}");
            

            Console.WriteLine("\nЗадача 11.");
            Console.WriteLine("Введите значение N: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество чисел в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных: {Library.Cycles.SolveTask11(a)}");
            

            Console.WriteLine("\nЗадача 12.");
            Console.WriteLine("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В указанных числах одинаковых цифр: {Library.Cycles.SolveTask12(a,b)}");
            
            Console.WriteLine("\n\nТема Одномерные массивы");

            int[] Array = new int[8];
            Random random = new Random();

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(100);
                Console.Write($" {Array[i]}");
            }

            Console.WriteLine("\n\nЗадача 1.");
            Console.WriteLine($"Минимальный элемент массива: {Library.OneDimensionalArrays.FindMinimumElementOfArray(Array)}");

            Console.WriteLine("\n\nЗадача 2.");
            Console.WriteLine($"Максимаьный элемент массива: {Library.OneDimensionalArrays.FindMaximumElementOfArray(Array)}");

            Console.WriteLine("\n\nЗадача 3.");
            Console.WriteLine($"Индекс минимального элемента массива: {Library.OneDimensionalArrays.FindIndexOfElementOfArray(Array, Library.OneDimensionalArrays.FindMinimumElementOfArray(Array))}");

            Console.WriteLine("\n\nЗадача 4.");
            Console.WriteLine($"Индекс максимального элемента массива: {Library.OneDimensionalArrays.FindIndexOfElementOfArray(Array, Library.OneDimensionalArrays.FindMaximumElementOfArray(Array))}");

            Console.WriteLine("\n\nЗадача 5.");
            Console.WriteLine($"Сумма элементов массива с нечетными индексами равна: {Library.OneDimensionalArrays.SolveTask5(Array)}");

            Console.WriteLine("\n\nЗадача 6.");
            int[] СhangedArray = new int[Array.Length];
            СhangedArray = Library.OneDimensionalArrays.ReverseOneDimensionalArray(Array);
            Console.WriteLine($"Реверс массива: ");
            for (int i = 0; i < СhangedArray.Length; i++)
            {
                Console.Write($" {СhangedArray[i]}");
            }

            Console.WriteLine("\n\nЗадача 7.");
            Console.WriteLine($"Количество нечетных элементов массива: {Library.OneDimensionalArrays.SolveTask7(Array)}");
            
            Console.WriteLine("\n\nЗадача 8.");

            Console.WriteLine("\n\nМассив исходный:");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(100);
                Console.Write($" {Array[i]}");
            }

            СhangedArray = Library.OneDimensionalArrays.SolveTask8(Array);
            Console.WriteLine($"\nМассив после замены элементов: ");
            for (int i = 0; i < СhangedArray.Length; i++)
            {
                Console.Write($" {СhangedArray[i]}");
            }

            Console.Write($"\n");

            Console.WriteLine("\n\nЗадача 9.");
            СhangedArray = Library.OneDimensionalArrays.SortMinimumToMaximum(Array);
            Console.WriteLine($"Массив после сортировки по возрастанию: ");
            for (int i = 0; i < СhangedArray.Length; i++)
            {
                Console.Write($" {СhangedArray[i]}");
            }

            Console.WriteLine("\n\nЗадача 10.");
            СhangedArray = Library.OneDimensionalArrays.SortMaximumToMinimum(Array);
            Console.WriteLine($"Массив после сортировки по убыванию: ");
            for (int i = 0; i < СhangedArray.Length; i++)
            {
                Console.Write($" {СhangedArray[i]}");
            }

            Console.WriteLine("\n\nТема Двумерные массивы");

            int[,] TwoDimensionalArray = new int[10, 10];
            int[,] СhangedTwoDimensionalArray = new int[10, 10];
            Random r = new Random();

            for (int i = 0; i < TwoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDimensionalArray.GetLength(1); j++)
                {
                    TwoDimensionalArray[i, j] = r.Next(10, 100);
                    Console.Write(TwoDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\n\n");


            Console.WriteLine("\n\nЗадача 1.");
            Console.WriteLine($"Минимальный элемент массива: {Library.TwoDimensionalArrays.FindMinimumElementOfArray(TwoDimensionalArray)}");

            Console.WriteLine("\n\nЗадача 2.");
            Console.WriteLine($"Максимаьный элемент массива: {Library.TwoDimensionalArrays.FindMaximumElementOfArray(TwoDimensionalArray)}");

            Console.WriteLine("\n\nЗадача 3.");
            int[] IndexesOfElementOfArray = new int[2];
            IndexesOfElementOfArray = Library.TwoDimensionalArrays.FindIndexOfElementOfArray(TwoDimensionalArray, Library.TwoDimensionalArrays.FindMinimumElementOfArray(TwoDimensionalArray));
            Console.WriteLine($"Индекс минимального элемента массива: i({IndexesOfElementOfArray[0]})  j({IndexesOfElementOfArray[1]})");
            
            Console.WriteLine("\n\nЗадача 4.");
            IndexesOfElementOfArray = Library.TwoDimensionalArrays.FindIndexOfElementOfArray(TwoDimensionalArray, Library.TwoDimensionalArrays.FindMaximumElementOfArray(TwoDimensionalArray));
            Console.WriteLine($"Индекс минимального элемента массива: i({IndexesOfElementOfArray[0]})  j({IndexesOfElementOfArray[1]})");

            Console.WriteLine("\nЗадача 5.");
            Console.WriteLine($"Количество элементов массива,  которые больше своих левого, правого, верхнего и нижнего соседа одновременно: {Library.TwoDimensionalArrays.SolveTask5(TwoDimensionalArray)}");

            Console.WriteLine("\nЗадача 6.");
            СhangedTwoDimensionalArray = Library.TwoDimensionalArrays.TransposeMatrix(TwoDimensionalArray);
            
            Console.WriteLine("\n Массив после транспонирования: \n");
            for (int i = 0; i < СhangedTwoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < СhangedTwoDimensionalArray.GetLength(1); j++)
                {
                    Console.Write(СhangedTwoDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
