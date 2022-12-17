int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}
int M = Prompt("Какое колличество чисел вы планируете ввести? > ");
int CountNumbers(int M)
{
    int number = 0;
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        number = Prompt("Введите число > ");
        if (number > 0)
        {
            count++;
        }
    }
    return count;
}

System.Console.WriteLine($"В введённых вами числах {CountNumbers(M)} чисел больше 0");
