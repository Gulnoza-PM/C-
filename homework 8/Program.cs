/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2*/

int[,] table = new int[3, 5];
FillTableRandm(table);
PrintArray(table);
SortLower(table);
Console.WriteLine();
PrintArray(table);



void FillTableRandm(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Console.Write($"Сгенирированные числы {array [i,j]}");
            array[i, j] = new Random().Next(1, 10);
                       
        }
       
             
    }
}



void SortLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(1) - 1; c++)
            {
                if (array[i, c] < array[i, c + 1])
                {
                    int temp = array[i, c + 1];
                    array[i, c + 1] = array[i, c];
                    array[i, c] = temp;
                }
            }
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}