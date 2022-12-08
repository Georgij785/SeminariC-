int[] FillList(int[] list, int Down, int Up)
{
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = new Random().Next(Down, Up);
    }
    return list;
}

int chetnost(int[] list)
{
    int count = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] % 2 == 0) count++;
    }
    return count;
}
int[] Array = FillList(new int[10], 100, 1000);
System.Console.WriteLine(Array);
System.Console.WriteLine("Колличество чётных чисел в этом массиве > "+chetnost(Array));
