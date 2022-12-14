// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте массив");
int arry = int.Parse(Console.ReadLine()!);

int[] numbers = new int[arry];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Наш массив:");
PrintArray(numbers);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"состоит из {numbers.Length} чисел, из них {count} четные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }

    Console.Write("]");
    Console.WriteLine();
}





















