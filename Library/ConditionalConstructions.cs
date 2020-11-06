using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public static class ConditionalConstructions
    {
        public static int SolveTask1(int a, int b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }
        public static string SolveTask2(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return "Точка находится в 1 координатной четверти.";
              
            }
            else if (x < 0 && y > 0)
            {
                return "Точка находится во 2 координатной четверти.";
                
            }
            else if (x < 0 && y < 0)
            {
                return "Точка находится в 3 координатной четверти.";
               
            }
            else if (x > 0 && y < 0)
            {
                return "Точка находится во 4 координатной четверти.";
                
            }
            else if (x == 0)
            {
                if (y==0)
                {
                    return "Это точка начала координат.";
                }
                return "Точка находится на оси абсцисс.";
                
                
            }
            else if (y==0)
            {
                return "Точка находится на оси ординат.";
               
            }
            else
            {
                return "Ошибка.";
            }
        }

        public static int[] SolveTask3(int a, int b, int c)
        {
            int[] Numbers = new int[3];

            if (a <= b && a <= c)
            {
                if (b < c)
                {
                    Numbers[0] = a;
                    Numbers[1] = b;
                    Numbers[2] = c;
                    return Numbers;
                }
                else 
                {
                    Numbers[0] = a;
                    Numbers[1] = c;
                    Numbers[2] = b;
                    return Numbers;
                }
            }
            else if (b <= a && b <= c)
            {
                if (a <= c)
                {
                    Numbers[0] = b;
                    Numbers[1] = a;
                    Numbers[2] = c;
                    return Numbers;
                }
                else 
                {
                    Numbers[0] = b;
                    Numbers[1] = c;
                    Numbers[2] = a;
                    return Numbers;
                }
            }
            else if (c <= a && c <= b)
            {
                if (a <= b)
                {
                    Numbers[0] = c;
                    Numbers[1] = a;
                    Numbers[2] = b;
                    return Numbers;
                }
                else 
                {
                    Numbers[0] = c;
                    Numbers[1] = b;
                    Numbers[2] = a;
                    return Numbers;
                }
            }
            return Numbers;
        }

        public static double[] SolveQuadraticEquation(int a, int b, int c)
        {
            double[] Results = new double[2];
            int D = (b*b) - 4 * a * c;
            
            if (D > 0)
            {
                Results[0] = (-b - Math.Sqrt(D)) / (2 * a);
                Results[1] = (-b + Math.Sqrt(D)) / (2 * a);
                return Results;
            }
            else if (D == 0)
            {
                Results[0] = (-b)/(2*a);
                return Results;
            }
            else
            {
                Results[0] = 0;
                Results[1] = 0;
                return Results;
            }
        }
        public static string[] SolveTask5(int a)
        {
            string[] Results = new string[2];
            if (a / 10 == 0)
            {
                Results[0] = "Вы ввели число меньше 10.";
                Results[1] = "";
                return Results;
            }

            else if (a / 10 == 1)
            {
                if (a % 10 == 0)
                {
                    Results[0] = "Десять.";
                    Results[1] = "";
                    return Results;
                }
                else if (a % 10 == 1)
                {
                    Results[0] = "Одиннадцать.";
                    Results[1] = "";
                    return Results;
                }
                else if (a % 10 == 2)
                {
                    Results[0] = "Двенадцать.";
                    Results[1] = "";
                    return Results;
                }
                else if (a % 10 == 3)
                {
                    Results[0] = "Тринадцать.";
                    Results[1] = "";
                    return Results;
                }
                else if (a % 10 == 4)
                {
                    Results[0] = "Четырнадцать.";
                    Results[1] = "";
                    return Results;
                }
                else if (a % 10 == 5)
                {
                    Results[0] = "Пятнадцать.";
                    Results[1] = "";
                    return Results;
                }
                else if (a % 10 == 6)
                {
                    Results[0] = "Шестнадцать.";
                    Results[1] = "";
                    return Results;
                }
                else if (a % 10 == 7)
                {
                    Results[0] = "Семнадцать.";
                    Results[1] = "";
                    return Results;
                }
                else if (a % 10 == 8)
                {
                    Results[0] = "Восемнадцать.";
                    Results[1] = "";
                    return Results;
                }
                else if (a % 10 == 9)
                {
                    Results[0] = "Девятнадцать.";
                    Results[1] = "";
                    return Results;
                }
            }

            else if (a / 10 == 2)
            {
                Results[0] = "Двадцать ";
            }

            else if (a / 10 == 3)
            {
                Results[0] = "Тридцать ";
            }

            else if (a / 10 == 4)
            {
                Results[0] = "Сорок ";
            }

            else if (a / 10 == 5)
            {
                Results[0] = "Пятьдесят ";
            }

            else if (a / 10 == 6)
            {
                Results[0] = "Шестьдесят ";
            }

            else if (a / 10 == 7)
            {
                Results[0] = "Семьдесят ";
            }

            else if (a / 10 == 8)
            {
                Results[0] = "Восемьдесят ";
            }

            else if (a / 10 == 9)
            {
                Results[0] = "Девяносто ";
            }

            else
            {
                Results[0] = "Вы ввели число больше 100.";
            }

            if (a%10 == 0)
            {
                Results[1] = ".";
            }

            else if (a % 10 == 1)
            {
                Results[1] = "один.";
            }

            else if (a % 10 == 2)
            {
                Results[1] = "два.";
            }

            else if (a % 10 == 3)
            {
                Results[1] = "три.";
            }

            else if (a % 10 == 4)
            {
                Results[1] = "четыре.";
            }

            else if (a % 10 == 5)
            {
                Results[1] = "пять.";
            }

            else if (a % 10 == 6)
            {
                Results[1] = "шесть.";
            }

            else if (a % 10 == 7)
            {
                Results[1] = "семь.";
            }

            else if (a % 10 == 8)
            {
                Results[1] = "восемь";
            }

            else if (a % 10 == 9)
            {
                Results[1] = "девять.";
            }

            return Results;
        }

    }
}
