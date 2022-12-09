/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Please enter number");

string userEntered = Console.ReadLine()!;


if (userEntered.Length<3)
{
    Console.WriteLine("Invalid number");

 }
else
{
   Console.WriteLine(userEntered[2]);
} 









