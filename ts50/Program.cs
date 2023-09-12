// Задача 50. Напишите программу, которая на вход принимает позиции
//  элемента в двумерном массиве, и возвращает значение
//   этого элемента или же указание,
//    что такого элемента нет.
static int[,] GenerateRandomArray(int rows, int columns)
{
    Random random = new Random();
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = random.Next(0, 100);
        }
    }

    return result;
}

int Input(string msg)
{
    Console.WriteLine(msg);
 int res = Convert.ToInt32(Console.ReadLine());
 return res;
}

   void PrintArray(int[,] randomArray)
    {
        for (int i = 0; i < randomArray.GetLength(0); i++)
        {
            for (int j = 0; j < randomArray.GetLength(1); j++)
            {
                Console.Write(randomArray[i, j] + " ");
            }
    Console.WriteLine();
    }   
        
    }

static object GetElementValue (int[,] randomArray, int x, int y) 
  {
      if (randomArray.GetLength(0) <= x || randomArray.GetLength(1) <= y)
         return "Element is out of bounds.";
      
      return randomArray[x - 1, y - 1];
  }  


    int rows = 5;
    int columns = 10;

    int[,] randomArray = GenerateRandomArray(rows, columns);


   PrintArray(randomArray);
    
    int x = Input("Enter x ");
    int y = Input("Enter y ");

    object elementValue = GetElementValue(randomArray, y, x);

    Console.WriteLine($"Element value: {elementValue}");