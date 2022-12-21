﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите точку k1: ");
double K1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите точку b1: ");
double B1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите точку k2: ");
double K2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите точку b2: ");
double B2 = double.Parse(Console.ReadLine()!);

double x = GetX(B2, B1, K1, K2);
double y = GetY(K1, x, B1);

x = GetCube(x);
y = GetCube(y);

Console.WriteLine($"Пересечение в точке: ({x};{y})");

double GetX(double B2, double B1, double K1, double K2)
{
    double result = (B2 - B1) / (K1 - K2);
    return result;
}

double GetY(double K1 ,double x,  double B1)
{
    double result = K1 * x + B1;

    return result;
}

double GetCube(double num)
{
    return Math.Round(num, 3);
}