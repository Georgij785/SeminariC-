// Задача 3

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
System.Console.Write("Введите ваше число  >");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= N)
{
    System.Console.WriteLine(count * count);
    count++;
}