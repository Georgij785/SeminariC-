void PrintList(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        System.Console.WriteLine(list[i]);
    }
}
int[] Rotate(int[] list)
{
    int count=1;
    int number=0;
    for (int i = 0; i <list.Length/2; i++)
    {
        number=list[i];
        list[i]=list[list.Length-count];
        list[list.Length-count]=number;
        count++;
    }
    return list;
}

int[] array={1,2,3,4,5};
PrintList(array);
System.Console.WriteLine();

PrintList(Rotate(array));