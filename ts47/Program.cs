// Задача 47. Задайте двумерный массив размером m×n, заполненный
//  случайными вещественными числами.
  
using System;

class Program
{
    static void Main()
    {
        // Размеры массива
        int m = 3;
        int n = 4;

        // Инициализация двумерного массива
        double[,] array = new double[m, n];

        Random rnd = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rnd.NextDouble();
                Console.Write($"{array[i, j]:F2} ");
            }
            Console.WriteLine();
        }
    }
}