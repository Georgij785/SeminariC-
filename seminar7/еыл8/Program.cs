
Console.Write("Введите ваше число >");
int mynum = Convert.ToInt32(Console.ReadLine());
string mystr = Convert.ToString(mynum);
int myres = 0;
Console.WriteLine("myres = " + myres);
Console.WriteLine("mystr = " + mystr);
for (int i = 0; i < mystr.Length; i++)
{
    Console.WriteLine("i = " + i);
    myres = myres + Convert.ToInt32(mystr[i]);
}
Console.WriteLine(myres);
Console.Write("Введите ваше число >");
int mynum = Convert.ToInt32(Console.ReadLine());
string mystr = Convert.ToString(mynum);
int myres = 0;
Console.WriteLine("myres = " + myres);
Console.WriteLine("mystr = " + mystr);
for (int i = 0; i < mystr.Length; i++)
{
    Console.WriteLine("i = " + i);
    myres = myres + Convert.ToInt32(mystr[i]);
}
// Console.WriteLine(myres);