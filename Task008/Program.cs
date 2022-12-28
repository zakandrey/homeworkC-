Console.Write("Введите число: ");
string number = Console.ReadLine();
if (number.Length !=5)
{
    System.Console.WriteLine("Введите пятизначное число");
    return;
}
if (number[0]==number[4] && number[1]==number[3])
{
    System.Console.WriteLine("Палиндром");
}
else {
    System.Console.WriteLine("Не палиндром");
}