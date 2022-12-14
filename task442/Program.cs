/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11 / 82 -> 10 / 9012 -> 12*/
Console.WriteLine("Enter number");
int num= int.Parse(Console.ReadLine()!);
Console.WriteLine($"Sum of digits={SumOfDigits(num)}");


int SumOfDigits(int number)

{
    int sum=0;
    int result=0;
    while(number>0)
    {
        sum=number%10;
        number=number-sum;
        result= result+sum;
        number = number/10;
    }
    return result;

}









