// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ряд > 1
// Колонка > 7
// 1, 7 -> такого числа в массиве нет


int Promt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
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
int SearchInMatrix(int[,] matrix, int row, int column)
{
    row -= 1;
    column -= 1;
    return matrix[row, column];
}
bool Validate(int m, int n, int[,] array)
{
    if (m <= array.GetLength(0) && n <= array.GetLength(1) && m > 0 && n > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
int row = Promt("введите искомую строку > ");
int column = Promt("введите искомый столбец > ");
int[,] array = CreateFillArray(5, 6);
PrintArray(array);
if (Validate(row, column, array))
{
    System.Console.WriteLine($"елемент, стоящий на введённых позициях ={SearchInMatrix(array, row, column)}");
}
else
{
    System.Console.WriteLine("такого элемента нет(");
}