//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double[size];
GetArrayInString(numbers);
FillArrayRandomNumbers(numbers);
double max = numbers[0];
double min = numbers[0];

string GetArrayInString (double [] numbers)
{
    return String.Join(",", numbers);
}
Console.WriteLine(GetArrayInString(numbers));

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max )
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($"всего {numbers.Length} чисел. Максимальное число = {max}, минимальное число = {min}");
Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(1, 100);
 }
}
