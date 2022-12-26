// адайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int n, m, 
Console.Write("Введи значение от: ");
int N= int.Parse(Console.ReadLine()!);
Console.Write("Введи значение до: ");
int M = int.Parse(Console.ReadLine()!);

void Numbers(int n, int m)
{
    int s=0;
for (int i = n; i <= m; i++)
{
    s += i;
}
    
Console.WriteLine(s);
}

Numbers(N,M);
