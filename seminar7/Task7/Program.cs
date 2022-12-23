// Задача 5: Задайте двумерный массив. Найдите максимальный элемент массива и среднее арифметическое всех элементов массива.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Максимальный элемент массива 9
// Среднее арифметическое 4.25
int Maximum(int[,] matr)
{
    int max = matr[0, 0];
    foreach (int item in matr)
    {
        if (max < item) max = item;
    }
}
double Average(int[,] list)
{
    int sum = 0;
    foreach (int item in list)
    {
        sum += item;
    }
    return sum / list.Length;
}
int[,] FillCreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
int Prompt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int Rows = Prompt("rows > ");
int Columns = Prompt("columns > ");
int[,] Array = FillCreateArray(Rows, Columns);
PrintArray(Array);
System.Console.WriteLine($"Максимальное ={Maximum(Array)}");
System.Console.WriteLine($"Среднее арифметичнское ={Average(Array)}");
