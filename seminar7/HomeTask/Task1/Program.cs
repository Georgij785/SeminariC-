// Задача 1. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int Promt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
double[,] CreateFillArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            double number = new Random().Next(-10, 10);   //}
            array[i, j] = new Random().Next(1, 10) / number; //} для создания нецелых чисел
        }
    }
    return array;
}
void PrintArray(double[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            System.Console.Write($"{list[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int m = Promt("введите коддичество строк > ");
int n = Promt("введите коддичество столбцов > ");
PrintArray(CreateFillArray(m, n));