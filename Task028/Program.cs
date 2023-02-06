//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman (int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (m > 0 && n == 0)
    {
        n = Akkerman (m - 1, 1);
        return n;
    }
    else if (m > 0 && n > 0)
    {
        n = Akkerman (m, n - 1);
        n = Akkerman (m - 1, n);
    }
    return n;
}

int m = InputNumber ("Введите число M: ");
int n = InputNumber ("Введите число N: ");
Console.WriteLine ($"A ({m}, {n}) = {Akkerman (m, n)}");


int InputNumber (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}
