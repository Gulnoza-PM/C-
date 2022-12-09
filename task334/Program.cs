/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите кординату Х точки А: ");
int xa= int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите кординату Y точки А: ");
int ya= int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите кординату Z точки А: ");
int za= int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите кординату Х точки B: ");
int xb= int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите кординату Y точки B: ");
int yb= int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите кординату Z точки B: ");
int zb= int.Parse(Console.ReadLine()!);




double H= (double)Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
Console.WriteLine(" Расстояния между точками = " + Math.Round(H,2));
