int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}
double k1=Prompt("введите k1 > ");
double b1=Prompt("введите b1 > ");
double k2=Prompt("введите k2 > ");
double b2=Prompt("введите b2 > ");

// y=k1*x+b1;
// y=k2*x+b2;

double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;
System.Console.WriteLine($"({x};{y})");