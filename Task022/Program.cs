// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int InputNumber(string message)
{
    Console.Write(message);
    var number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray(int[,] array)
{
    Random rnd = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i , j] = rnd.Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,5}", array[i, j] + " "));
        }
        System.Console.WriteLine();
    }
}

void SwapElements(int [,] array, int i, int j, int k)
{
  int temp = array [i, k];
  array [i, k] = array [i, j];
  array [i, j] = temp;
}

void BubleSortRowIn2DArray(int [,] array, int i)
{
  for (int j = 0; j < array.GetLength(1) - 1; j++)
  {
    for (int k = j + 1; k < array.GetLength(1); k++)
    {
      if (array [i, j] < array [i, k])
      {
        SwapElements(array, i, j, k);
      }
    }
  }
}

void SortArray (int [,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    BubleSortRowIn2DArray(array, i);
  }
}

var rows = InputNumber("Введите количество строк массива: ");
var columns = InputNumber("Введите количество столбцов массива: ");

int [,] Array = new int [rows, columns];

FillArray(Array);
PrintArray(Array);
SortArray(Array);
Console.WriteLine();
PrintArray(Array);