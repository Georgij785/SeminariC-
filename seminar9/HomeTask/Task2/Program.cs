// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNumbers(int M, int N)
{
    if (M == N)
    {
        return N;
    }
    return M + SumNumbers(M + 1, N);
}

int M = 1;
int N = 5;
if (M < N)
{
    System.Console.WriteLine(SumNumbers(1, 5));

}
if (M > N)
{
    System.Console.WriteLine(SumNumbers(N, M));

}
if (M == N)
{
    System.Console.WriteLine(M);
}