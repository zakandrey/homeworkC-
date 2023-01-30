// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int InputNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray2D(int[,] array2D)
{
    Random rnd = new Random();

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i , j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i, j] + ("  "));
        }
        System.Console.WriteLine();
    }
}

int rows = InputNumber("Введите количество строк массива: ");
int columns = InputNumber("Введите колчисетво столбцов массива: ");

int [,] newArray = new int [rows, columns];

// PrintArray2D(newArray);
FillArray2D(newArray);
Console.WriteLine();
PrintArray2D(newArray);
Console.WriteLine();


int numberInRow = InputNumber("Введите номер строки: ");
int numberInColumns = InputNumber("Введите номер столбца: ");

if (numberInRow -1 > newArray.GetLength(0) 
    || numberInColumns - 1 > newArray.GetLength(1))
    {
        System.Console.WriteLine("Такого числа нет в массиве");
    }
    else
    {
        System.Console.WriteLine("Значение ячейки: " 
        + newArray[numberInRow - 1, numberInColumns - 1]);
    }