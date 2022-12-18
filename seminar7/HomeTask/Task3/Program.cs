// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateFillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] list)
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
double[] AverageColumn(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double count = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            count += matrix[j, i];
        }
        average[i] = count / matrix.GetLength(0);
    }
    return average;
}
void PrintList(double[] list)
{
    for (int i = 0; i < list.Length; i++)
    {

        System.Console.Write($"{list[i]} ");
        System.Console.WriteLine();
    }
}
int[,] matrix = CreateFillArray(5, 6);


PrintList(AverageColumn(matrix));