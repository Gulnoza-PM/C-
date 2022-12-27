// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Ведите номер: 5");
int N=int.Parse(Console.ReadLine()!);
void Numbers(int n)
{
    Console.Write($" {n} ");
    if(n!=1) Numbers(n-1);
    
}
Numbers(N);