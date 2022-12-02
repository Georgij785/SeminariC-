int DELETE2NUMBER(int number)
{
    int desatki = number / 10 % 10;
    number = number - desatki * 10;
    int edinisi = number % 10;
    number=number/10;
    number= number+edinisi;
    return number;
}
int number=new Random().Next(100, 999);
System.Console.WriteLine("Изначальноу сгенерированное число > " + number);
System.Console.WriteLine("оно-же, но без 2-й цифры > "+DELETE2NUMBER(number));