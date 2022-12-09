/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.456 -> 5
782 -> 8
918 -> 1*/

for (int i= 0; i<3; i+=1)
{
    Console.WriteLine("Please enter number");

    string userEntered = Console.ReadLine()!;
    Console.WriteLine(userEntered[1]);



}


