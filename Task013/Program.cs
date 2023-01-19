int [] array = new int[8];
Console.Write("[");

for (int i = 0; i < array.Length; i++)
 {
    array [i] = new Random().Next(0, 100);
 }

    Console.Write(GetArrayInString(array));
    Console.Write("]");

string GetArrayInString (int [] array)
{
    return String.Join(",", array);
}