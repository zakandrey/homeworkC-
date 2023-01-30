// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int InputNumber(string message)
{
    Console.Write(message);
    var number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray2D(int[,] array2D)
{
    Random rnd = new Random();

    for (var i = 0; i < array2D.GetLength(0); i++)
    {
        for (var j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i , j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray2D(int[,] array2D)
{
    for (var i = 0; i < array2D.GetLength(0); i++)
    {
        for (var j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i, j] + ("  "));
        }
        System.Console.WriteLine();
    }
}

void AverageInArray(int[,] array2D)
{
    for (var j = 0; j < array2D.GetLength(1); j++)
    {
        double sum = 0;
        for (var i = 0; i < array2D.GetLength(0); i++)
        {
            sum += array2D[i , j];
        }
        double average = sum / array2D.GetLength(0);
        System.Console.WriteLine("Среднее по " 
        + (j + 1) + " столбцу = " + Math.Round((average), 2));
    }
}

var rows = InputNumber("Введите количество строк массива: ");
var columns = InputNumber("Введите колчисетво столбцов массива: ");

int [,] newArray = new int [rows, columns];

FillArray2D(newArray);
Console.WriteLine();
PrintArray2D(newArray);
Console.WriteLine();
AverageInArray(newArray);
System.Console.WriteLine();