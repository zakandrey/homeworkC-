Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

    if (number / 100 != 0)
{
    while (number > 999)
    {
        number /= 10;
    }
    int answer = number % 10;
    System.Console.WriteLine(answer);
}
else 
    System.Console.WriteLine("Третьей цифры нет");