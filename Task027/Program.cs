// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummNumber (int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else 
    {
        n += SummNumber (m, n-1);
    }
    return n;
}

int m = InputNumber ("Введите число M: ");
int n = InputNumber ("Введите число N: ");
Console.WriteLine ($"Сумма чисел от {m} до {n} = {SummNumber (m, n)}");

int InputNumber (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}