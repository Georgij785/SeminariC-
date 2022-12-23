void PrintArray(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            System.Console.Write($"{list[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
int[] FindMinRowSum(int[,] matrix)
{   
    int[] sums=new int[matrix.GetLength(0)];
    int result=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum=0;
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            sum+=matrix[i,j];
        }
        sums[i]=sum;
    }
    return sums;
}
int FindMinIndex(int[] list)
{
    int min=list[0];
    int minI=0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i]<min)
        {
            min=list[i];
            minI=i;
        }
    }
    return minI;
}
int[,] CreateFillArray(int m,int n)
{
    int[,] array=new int[m,m+3];
    for (int i = 0; i < m ;i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j]=new Random().Next(1,10);
        }
    }
    return array;
}
int[,] array=CreateFillArray(4,7);
PrintArray(array);
System.Console.WriteLine(FindMinIndex(FindMinRowSum(array)));