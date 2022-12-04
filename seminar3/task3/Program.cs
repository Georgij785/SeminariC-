// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Kub(int Number)
{
    int count = 1;
    while (count <= Number)
    {
        int result = count * count * count;
        count++;
        System.Console.WriteLine(result);
    }
}

System.Console.Write("Введите ваше число  >");
int N = Convert.ToInt32(Console.ReadLine());

Kub(N);