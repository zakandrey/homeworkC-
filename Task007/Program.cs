Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
System.Console.WriteLine("Такого дня недели нет");
return;
}
if (number >= 1 && number <= 5)
{
    System.Console.WriteLine("Будний день");

}
else
{
    System.Console.WriteLine("Выходной день");
}