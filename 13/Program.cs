// Даны целочисленные массивы X и Y с разным количеством элементов.   
// Найти минимальные элементы этих массивах среди элементов, имеющих четный индекс.

int[] array = new int[12];
int[] array1 = new int[8];

void RandomArray(int[] arr,int[] arr1){
    Random rnd = new Random();
    for(int i= 0; i<arr.Length;i++)
{
arr[i] = rnd.Next(0,55);
}
    for(int i= 0; i<arr1.Length;i++)
{
arr1[i] = rnd.Next(0,155);
}
}

void Difference(int[] arr,int[] arr1){
    int max=0;
    //int max1=0;
    //int res =0;
    for(int i= 0; i<arr.Length;i++){
        if((i%2==0)&&(arr[i]>max)) {max=arr[i];//Console.WriteLine(max);
        }
    for(int j= 0; j<arr1.Length;j++){
         if((j%2==0)&&(arr1[j]>max)) {max=arr1[j];//Console.WriteLine(max);
    }    
       }
       
       }
Console.WriteLine("Максимальное число: "+max);
}


void PrintArray(int[]arr,int[] arr1){

Console.Write( "Результат: ");
   for(int i= 0; i<arr.Length;i++)
   { 
    Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    
Console.Write( "Результат: ");
   for(int i= 0; i<arr1.Length;i++)
   { 
    Console.Write($"{array1[i]} ");
    }
   Console.WriteLine();
   

   
}
RandomArray(array,array1);
PrintArray(array,array1);
Difference(array,array1);