System.Console.Write("Ведите колличество элементов в массиве, которое вы хотите >");
int length = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите нижнюю границу чисел в будущем массиве >");
int Down = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите верхнюю границу чисел в будущем массиве >");
int Up = Convert.ToInt32(Console.ReadLine());

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


void PrintList(int[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        System.Console.WriteLine(list[i]);
    }
}

PrintList(FillList(CreateList(length), Down, Up));