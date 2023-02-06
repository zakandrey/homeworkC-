// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Naturalnumber (int number)
{
    if (number == 1) 
    {
        return 1;
    }
    else 
    {
        Console.Write ($"{number}, ");
        number = Naturalnumber (number - 1);
    }
        return number;
}

int number = InputNumber ("Введите число N: ");
Console.WriteLine(Naturalnumber (number));

int InputNumber (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}