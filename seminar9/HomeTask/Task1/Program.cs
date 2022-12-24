// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"
bool Validate(int M, int N)
{
    if (N > M)
    {
        return true;
    }
    return false;
}
void FromMToNDelitel2Plus(int M, int N)
{
    if (M > 0)
    {
        if (M == N || (M + 1) == N)
        {
            if ((M % 2 )==1)
            {
                M+=1;
            }
            System.Console.WriteLine(M);
            return;

        }
        System.Console.WriteLine(M);

    }
    if ((M % 2) == 1||(M % 2) == -1)
    {
        M+=1;
    }
    
    FromMToNDelitel2Plus(M+2, N);
}



int M = 30;
int N = 10;
if (Validate(M, N))
{
    FromMToNDelitel2Plus(M, N);
}
else
{
    FromMToNDelitel2Plus( N,M);
}