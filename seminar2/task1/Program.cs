// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки

// 456 -> 5
// 782 -> 8
// 918 -> 1


int Promt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int number = (Promt("Напишите ваше ТРЁХЗНАЧНОЕ число"));
int result = number / 10 % 10;
System.Console.WriteLine($"2-я цифра вашего(надеюсь трёхзначного) числа {result}");