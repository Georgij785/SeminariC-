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
(int?,int?) Search(int[,] list,int SearchElement)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            if (list[i,j]==SearchElement)
            {
                return (i,j);
                
            }
        }
    }
    return (null,null);


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
int m = Prompt("Введите число строк  > ");
int n = Prompt("Введите число стобцов  > ");
int[,] array =FillCreateArray(m,n);
PrintArray(array);
int Element=Prompt("Введите искомый элемент > ");

(int? FR, int? FC)=Search(array,Element);
if (FR==null||FC==null)
{
    System.Console.WriteLine("Такого элемента нет");
}
System.Console.WriteLine($"Координаты искомого= {FR},{FC}");