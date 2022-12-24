Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number / 10 % 10;

System.Console.WriteLine(result);