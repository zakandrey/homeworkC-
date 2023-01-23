//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int summ = 0;
for (int i = 1; i < numbers.Length; i+=2)
  {
summ += numbers[i];
  }
Console.WriteLine($"всего {numbers.Length} чисел, {summ} - сумма нечетных позиций в массиве");

void FillArrayRandomNumbers(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(-10, 10);
 }
}

