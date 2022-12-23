int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

int[,] FillCreateArray(int m,int n)
{
    int[,] array=new int[m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=(i+1)*(j+1);
        }
    }
    return array;
}
 void PrintArrayTwo(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}
int m=Prompt("Введите количество строк > ");
int n =Prompt("Введите колличество столбцов > ");

PrintArrayTwo(FillCreateArray(m,n));