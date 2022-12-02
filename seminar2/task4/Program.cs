int[] week={0,1,2,3,4,5,6};
//  Понедельник Вторник Среда Четверг Пятница Суббота Воскресенье
System.Console.Write("Введите число > ");
int number =Convert.ToInt32(Console.ReadLine());
bool moremin(int number)
{
    if (number<8&&number>0)
    {
        return true;
        
    }
    return false;
}   
if (moremin(number))
{
    number=number-1;
    if (number==6)
    {
        System.Console.WriteLine("Да, это воскресенье");
    }
    
    else 
    {
        if (number==5)
        {
            System.Console.WriteLine("Да, это суббота");
        
        }
       else
        {
            System.Console.WriteLine("Это рабочий день:(");
        }
    }
    
}
else
{
    System.Console.WriteLine("Ваше число слишком большое или маленькое, перезапустите программу и введите число от 1 до 7");
}