// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            array[i , j] = rnd.Next(5);
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

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i, k] * secomdMartrix[k, j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumber("Введите число строк 1-й матрицы: ");
int n = InputNumber("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumber("Введите число столбцов 2-й матрицы: ");

int[,] firstMartrix = new int[m, n];
FillArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
FillArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);