/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 7 -> да 1 -> нет */ 
//string[] date = {"pon", "vtor","sred","chet","pyat","sub","vosk"};

Console.WriteLine("Please enter number");

int userEntered = int.Parse(Console.ReadLine());


if (userEntered == 6 || userEntered == 7)

{
    Console.WriteLine("da");

 }

 else if(userEntered>7)

 {   
        Console.WriteLine("Invalid date");

 }

else
{
   Console.WriteLine("net");
} 


