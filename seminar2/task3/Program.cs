System.Console.Write("Введите ваше число >");
int number = Convert.ToInt32(Console.ReadLine());
int TOTHREE(int number)
{
    while (number > 999)
    {
        number = number / 10; 
    }
    int result=number%10;
    return result;
}
if (number<100)
{
    System.Console.WriteLine("Третьей цифры нет.");
}
else
{
    System.Console.WriteLine("Третья цифра с начала > "+TOTHREE(number));
}

