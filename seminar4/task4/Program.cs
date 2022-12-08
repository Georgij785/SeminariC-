

int Down = 1;
int Up = 99;
void PrintList(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        System.Console.WriteLine(list[i]);
    }
}
int[] CreateList(int count)
{
    int[] array = new int[count];
    return array;
}


int[] FillList(int[] list, int Down, int Up)
{
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = new Random().Next(Down, Up);
    }
    return list;
}

int SecondMax(int[] list)
{
    int max = list[0];
    int max2 = list[0];
    for (int i = 0; i < list.Length; i++)
    {
        if (max < list[i] || max > list[i])
        {
            if (max < list[i])
            {
                max2 = max;
                max = list[i];
            }
            if (max > list[i])
            {
                if (max2 < list[i] || max2 == max)
                {
                    max2 = list[i];
                }
            }
        }
    }
    return max2;

}
int[] array = FillList(CreateList(10), Down, Up);
PrintList(array);
System.Console.WriteLine();
System.Console.WriteLine("Второе максимальное >" + SecondMax(array));
