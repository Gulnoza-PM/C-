// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
Console.Write("Напишите сколько чисел хотите ввести: ");
int Input=int.Parse(Console.ReadLine()!);

void getInputCount(int userInput)
{
int count=0;
for(int i=1;i<=userInput;i++)
{
    System.Console.Write($"Введите номер  {i}ый: ");
    int num = int.Parse(Console.ReadLine()!);
    if(num > 0)
        count++;
};
Console.WriteLine($"Количество номеров больше 0: {count}");

}
getInputCount(Input);






//  int Max(int arg1, int arg2, int arg3)
// {
//     int res = arg1;
//     if(arg2> res) res = arg2;
//     if(arg3> res) res = arg3;
//     return res;
// }
// int a = 33; int b =78; int c=88; int d=71; int e = 33; int g =73; int f=83; int y=713; int r=716; 
// int max1=Max(a, b, c);
// int max2=Max(d, e, g);
// int max3=Max(f, y, r);

// int maxRes=Max(max1, max2, max3);
// Console.WriteLine(maxRes);


// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Кол-во элементов > 0: {count}");

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = arr.Count(x => x > 0);
// Console.WriteLine($"Кол-во элементов > 0: {count}");
