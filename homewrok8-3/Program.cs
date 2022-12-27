// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//Console.WriteLine($"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n\nСразу зададим матрицу, которую можно перемножить, т.е. количество столбцов первой равно количеству строк второй");
//Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int line = UserInputNumbers("Введите количество строк 1-й матрицы: ");
int columCount1 = UserInputNumbers("Введите  количество 1-й матрицы (и строк 2-й): ");
int columCount2 = UserInputNumbers("Введите  количество 2-й матрицы: ");
int range = UserInputNumbers("Введите диапазон чисел: от 1 до ");

int[,] Martrix1 = new int[line, columCount1];
CreateArray(Martrix1);
Console.WriteLine($"\nПервая матрица:");
WriteArray(Martrix1);

int[,] Martrix2 = new int[columCount1, columCount2];
CreateArray(Martrix2);
Console.WriteLine($"\nВторая матрица:");
WriteArray(Martrix2);

int[,] resultMatrix = new int[line,columCount2];

MultiplyMatrix(Martrix1, Martrix2, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] Martrix1, int[,] Martrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrix1.GetLength(1); k++)
      {
        sum += Martrix1[i,k] * Martrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int UserInputNumbers(string input)
{
  Console.Write(input);
  int show = int.Parse(Console.ReadLine()!);
  return show;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}