//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] GetArray(int m, int n, int begin, int end)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(1, 50);
        }
    }
    return arr;
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] arr = GetArray(4, 4, 1, 50);

void ShowElement(int[,] arr)
{
    int count = 5;
    while (true)
    {
        
        Console.Write("Строки- ");
        int rows = int.Parse(Console.ReadLine()!);
        Console.Write("Столбцы- ");
        int columns = int.Parse(Console.ReadLine()!);
        try
        {
            Console.Write($" Элементы [{rows}, {columns}] ");
            Console.Write($" является: {arr[rows, columns]} ");
            
            break;
        }
        catch
        {
            Console.WriteLine("Элемент не сушествует!");
            count--;
            if (count == 0)
            {
                Console.WriteLine("Ошибка.");
                break;
            }
                   }


    }
}

ShowArray(arr);
ShowElement(arr);
