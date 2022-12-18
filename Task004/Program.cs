Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int evenNum = 2;
    if (number > 1)
    {
    while (evenNum<=number)
    {
        System.Console.WriteLine(evenNum + " ");
        evenNum = evenNum + 2;
    }
    }