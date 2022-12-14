// // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0//

int[] CreateRandomArray(int size, int start, int end)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(start, end);
    
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Генерированный массив ");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) 

    Console.Write($"{array[i]}, ");
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int SumOfArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) 
    {
        sum = sum+array[i];
    }
    return sum;
}


int[] OurArray = CreateRandomArray(10, 1, 100);

PrintArray(OurArray);
Console.WriteLine($"Сумма нечетных элементов: {SumOfArray(OurArray)}");