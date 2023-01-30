//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray2D(double[,] array2D)
{
    Random rnd = new Random();

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i , j] = Math.Round(rnd.NextDouble() * 10, 1);
        }
    }
}

void PrintArray2D(double[,] array2D)
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

double [,] newArray = new double [rows, columns];


PrintArray2D(newArray);
FillArray2D(newArray);
Console.WriteLine();
PrintArray2D(newArray);
Console.WriteLine();
