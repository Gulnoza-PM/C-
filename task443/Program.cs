// // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

int [] numbers = new int[8];


for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    
 }

Console.WriteLine("[{0}]", string.Join(", ", numbers));

// // Console.WriteLine("Enter number");
// // int num= int.Parse(Console.ReadLine()!);



// int[] saveArray(int[] size);

// {
//     for(int i=0; i<arr.Length++;)
//     {
//         arr[i]=new Random().Next(-99,100);
//     }
//     return arr;

// }

// void printArra(int[]arr)
// {

//     for(int 1=0; int<arr.Length-1;int++)
// }
// Console.Write(arr[7] + ",");
// Console.Write("Massive : ");
// printArra(saveArray(0));