// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите первое число: ");
double NumberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
double NumberB = Convert.ToInt32(Console.ReadLine());

double result = 0;
for (int i = 1; i <= NumberB; i++)

result = Math.Pow(NumberA, NumberB);

{
    System.Console.WriteLine(result);
}
