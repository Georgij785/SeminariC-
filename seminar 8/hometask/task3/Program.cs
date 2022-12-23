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
int[,] MultiplyMatrixes(int[,] matrix1, int[,] matrix2)
{
    int[,] array = new int[matrix1.GetLength(0), matrix1.GetLength(0)];
    int res = 0;
    int index = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        index = 0;
        for (int l = 0; l < matrix1.GetLength(0); l++)
        {

            res = 0;
            if (i == matrix1.GetLength(0) - 1)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    res += matrix1[i, j] * matrix2[j, l];
                }
            }
            else
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    res += matrix1[i, j] * matrix2[j, l];
                }
            }
            array[i, index] = res;
            index++;

        }
    }
    return array;
}
int[,] matrix1 ={
    {2 ,5, 1},
    {3 ,2 ,1,},
    {4,2,6}
};
int[,] matrix2 ={
    {3 ,4,6,},
    {3,3,3,},
    {1,1,2}
};

PrintArray(MultiplyMatrixes(matrix1, matrix2));
