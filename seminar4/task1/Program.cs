int PromtA(string message)
{
    System.Console.Write($"{message}");
    int A = Convert.ToInt32(System.Console.ReadLine());
    return A;

}
int PromtB(string message2)
{
    System.Console.Write($"{message2}");
    int B = Convert.ToInt32(Console.ReadLine());
    return B;
}

int Stepeni(int A, int B)
{
    int count = 1;
    int A1=A;
    while (count < B)
    {
        
        A = A * A1;
        count++;
    }
    return A;
}
System.Console.WriteLine("Получившееся число > " + Stepeni(PromtA("Введите число, которое хотите возвести в степень > "), PromtB("Введите нужную вам степень > ")));