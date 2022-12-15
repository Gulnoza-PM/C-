// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76//

int[]array=new int[]{3,7,22,2,78};
int max=0;
int min=0;
for(int i = 0; i <= array.Length-1; i++ )
{
    
if( array[i]>max){
    max=array[i];
}
if(array[i]<max) 
    min=array[i];

}

void GetDifference(int max, int min){
    System.Console.WriteLine($"Difference is : {max-min}");
}

void PrintArray(int[] array){
    Console.Write("Our massive is: ");
    Console.WriteLine("[{0}]", string.Join(", ", array));
}
PrintArray(array);
GetDifference(max, min);


