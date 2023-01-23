// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[size];
GetArrayInString(numbers);
FillArrayRandomNumbers(numbers);

string GetArrayInString (int [] numbers)
{
    return String.Join(",", numbers);
}
Console.WriteLine(GetArrayInString(numbers));


int count = 0;
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} - чётные");

void FillArrayRandomNumbers(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(100, 1000);
 }
}


