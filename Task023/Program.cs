// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 


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
            array[i , j] = rnd.Next(0, 3);
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

int SummRow(int[,] array, int i)
{
  int summ = 0;
  for (int j = 0; j < array.GetLength(0); j++)
    {
        summ += array[i, j];
    }
  return summ;
}

int FindMinSummRow(int[,] array)
{
    int min = SummRow(array, 0);
    int index = 0;
for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentSumm = SummRow(array, i);
        if (currentSumm < min)
        {
            min = currentSumm;
            index = i;
        } 
    }
    return index + 1;
}

var rows = InputNumber("Введите количество строк массива: ");
var columns = InputNumber("Введите количество столбцов массива: ");

int [,] Array = new int [rows, columns];

FillArray(Array);
PrintArray(Array);
Console.WriteLine();
int MinSummRow = FindMinSummRow(Array);
Console.WriteLine(MinSummRow + " - строкa с наименьшей суммой");