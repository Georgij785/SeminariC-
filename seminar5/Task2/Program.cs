int SumChetint(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        result+=array[i];
    }
    return result;
}
int[] FillList(int[] list, int Down, int Up)
{
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = new Random().Next(Down, Up);
    }
    return list;
}

int[] array=new int[10];
System.Console.WriteLine(SumChetint(FillList(array,-100,101)));