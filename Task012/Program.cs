// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Summ = 0;
int result = 0;
for (int i = 0; Number > 0;i++)
{
Summ = Number % 10;
result += Summ;
Number = Number / 10;
}
{
    System.Console.WriteLine(result);
}