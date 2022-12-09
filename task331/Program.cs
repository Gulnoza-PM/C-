//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.//
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.WriteLine("Hello, World!");

Console.WriteLine("Number");
int Num=int.Parse(Console.ReadLine());
 int Number=1;
 Console.WriteLine($"Таблица кубов чисел{Num}, от 1 до {Num} ");
 while(Number<Num+1)
 {
    int result = Number*Number*Number;
    Console.WriteLine(result+",");
    Number ++;
 }
