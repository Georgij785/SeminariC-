System.Console.Write("Введите число >");
int Value=Convert.ToInt32(Console.ReadLine());

int Sum(int arg1)
{
    string arg2=Convert.ToString(arg1);
    int n=arg2.Length;
    int number=10;
    int res=0;
    for (int i = 0; i < n; i++)
    {
        res+=arg1%number;
        arg1=arg1/10;
    }
    return res;
}

System.Console.WriteLine(Sum(Value));