// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int Promt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
bool MoreMin(int number)
{
    if (number > 9999 && number < 100000)
    {
        return true;
    }
    else
    {
        return false;
    }
}


bool Palindrom(int number)
{
    int number2 = number;
    int edinitsi = number2 % 10 * 10000;
    number2 = number2 / 10;
    int desatki = number2 % 10 * 1000;
    number2 = number2 / 10;
    int sotni=number2%10*100;
    number2 = number2 / 10;
    int tisachi=number2%10*10;
    int desatkiTisach=number2/10;
    number2=edinitsi+desatki+sotni+tisachi+desatkiTisach;
    if (number==number2)
    {
        return true;
    }
    return false;
}

int number=Promt("Введите ваше число > ");

if (MoreMin(number))
{
    if (Palindrom(number))
    {
        System.Console.WriteLine("Да,это Поледром");
    }
    else
    {
        System.Console.WriteLine("Нет, это не поледром");
    }
}
else
{
    System.Console.WriteLine("Выше число слишком большое или слишком маленькое");
}

