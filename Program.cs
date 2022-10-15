using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 16
В заданной целочисленной матрице A(N, M) выведите на печать индексы первого
положительного элемента, кратного заданному числу К. Если таких элементов в матрице
нет, то выведите соответствующий текст. */

namespace _4_1_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {   
                { 7, 0, 6, -4, 9 },
                { 3, 1, 16, -7, 8 },
                { 7, 8, 9, 0, 2 },
                { 12, 0, 3, -4, 5 },
                { 13, 8, 9, 0, 4 },
            };
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);

            int k = 4;
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((arr[i, j] > 0) & (arr[i, j] % k == 0))
                    {
                        Console.WriteLine($"Первое число arr[{i}, {j}] = {arr[i, j]}");
                        flag = true;
                        goto Exit;
                    }                        
                }
            }
            Exit:
            if (!flag)
                Console.WriteLine($"Такого число нет.");
            Console.ReadKey();
        }
    }
}
