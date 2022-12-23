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
int[,] SortirovkaRows(int[,] list, int m)
{
    if (m == 0)
    {
        return list;
    }
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            if ((j + 1) < list.GetLength(1))
            {
                if (list[i, j] < list[i, j + 1])
                {
                    int number = list[i, j];
                    list[i, j] = list[i, j + 1];
                    list[i, j + 1] = number;
                }
            }

        }
    }
    SortirovkaRows(list, m - 1);
    return list;
}
int[,] matrix ={
    {9,0,2,1,},
    {5,3,56,8,},
    {45,23,2,5,}
};
PrintArray(matrix);
System.Console.WriteLine();
PrintArray(SortirovkaRows(matrix, matrix.GetLength(1)));