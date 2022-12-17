int[,] matrix={
    {1, 2, 3,},
    {3, 4, 5}
};
int res1=0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int max=matrix[0,0];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (max<matrix[i,j])
        {
           max=matrix[i,j]; 
        }
    }
    res1+=max;
}
int res2=0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    int min=matrix[0,0];
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        if (min>matrix[j,i])
        {
           min=matrix[j,i]; 
        }
    }
    res2+=min;
}
int result=res1-res2;
System.Console.WriteLine(result);