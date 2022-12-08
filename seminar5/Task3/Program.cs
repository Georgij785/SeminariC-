double MaxMin(double[] list)
{
    double max = list[0];
    double min = list[0];
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] > max) max = list[i];
        else
        {
            if (list[i] < min)
            {
                min = list[i];
            }
        }
    }
    double result = max - min;
    return result;
}

double[] array = { 7.6, 34, 4.456465656, 7.0, 23.5 };// Задаём массив вещественных чисел
System.Console.WriteLine(MaxMin(array));
