// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 2, 4 -> 16//

int RaiseNumber(int numA, int numB)
{
int result=1;
for (int i = 1 ; i <= numB ; i++)
{
    result = result*numA;
}
    // int result = Math.Pow(numA,numB);
return result;
}

Console.WriteLine("Enter number A: ");
int numA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number B: ");
int numB = int.Parse(Console.ReadLine()!);

int result = RaiseNumber(numA,numB);
Console.WriteLine($"Answer: {result}");
    





