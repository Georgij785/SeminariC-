// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("X для первой точки >");
double x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Y для первой точки >");
double y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Z для первой точки >");
double z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("X для второй точки >");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Y для второй точки >");
double y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Z для второй точки >");
double z2 = Convert.ToInt32(Console.ReadLine());

double A = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
System.Console.WriteLine("Расстояние между точками >"+Math.Sqrt((A * A) + (z1 - z2) * (z1 - z2)));



