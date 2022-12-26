// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,]table=new int[2,5];
//Генерируем рандомные числы
void FillTableRandm(int[,] array)
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
FillTableRandm(table); //Вызов 

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Console.Writeline ("generet: ");
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}
PrintArray(table);//  print 123
int minRow=0;
 int GetMinRowsum(int[,] array)
 {
    int result=0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int counter=0;
        for (int j = 0; j < array.GetLength(i); j++)
        {
            counter +=array[i,j];
        }
        if(result<counter)
        {
            result=counter;
            minRow=i+1;
        }

    }
    return result;
 }
int res =GetMinRowsum(table);
Console.WriteLine($"Минимальные элементы находится в : {minRow}");
Console.WriteLine($"Сумма элементов: {res}");

// SumLineElements(array, 0);
// {
// int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }
// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
  
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// Print(SumLineElements);