/ Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом 14212 -> нет 
// 12821 -> да 23432 -> //
//Besh xonali sonni kirituvchi va uning palindrom ekanligini tekshiradigan dastur yozing 14212 -> yo'q
// 12821 -> ha 23432 -> //
Console.WriteLine("Enter number");
int a = int.Parse(Console.ReadLine()!);
int first = a;
int result = 0;
if(a<10000||a>99999)
{
Console.WriteLine("Invalid number");
}
else 
{


while (a > 0)
{
    int remainder = a % 10;
    result += remainder;
    a -= remainder;
    a /= 10;
    result *= 10;
}

result /= 10;
if (result == first)
{
    Console.WriteLine("It is Polindrom");
}
else
{
    Console.WriteLine("It is not Polindrom");
}
}
