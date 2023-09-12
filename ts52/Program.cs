// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray(double[] averages)
{
    for(int i=0;i<averages.Length;i++)
    {
        Console.WriteLine(averages[i]);
    }
}

int[,] arr = new int[,] {
    {1, 2},
    {3, 4},
    {5, 6}
};


double[] averages = new double[arr.GetLength(0)];

for (int i = 0; i < arr.GetLength(0); i++)
 {
    double sum = 0.0;
    for (int j = 0; j < arr.GetLength(1); j++) {
        sum += arr[i, j];
    }
    averages[i] = sum / arr.GetLength(1);
}

PrintArray(averages);