// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,]table=new int[4, 4];
//Генерируем рандомные числы
void FillMatrixRandm(int[,] array)
{

    for(int i=0; i<array.GetLength(0); i++)
     {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Console.Write($"Сгенирированные числы {array [i,j]}");
            array[i, j] = new Random().Next(1, 10);
                       
        }
    }
}
FillMatrixRandm(table); //Вызов 

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Console.Writeline ("generet: ");
            Console.Write(array[i, j]+ " ");
        }
        Console.WriteLine();
    }
}
PrintMatrix(table);//  print 123


int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}
int res=MultMatrix(table);
//Console.WriteLine($"Минимальные элементы находится в : {minRow}");
Console.WriteLine($"Сумма элементов: {res}");