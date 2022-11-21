// Сортировка массива методом мин-мах

int[] arr = { 1, 3, 4, 5, 5, 6, 1, 8, 9 };

//метод для вывода на печать
void PrintArrau(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");

    }
    Console.WriteLine();
}

//Метод который сортирует массив

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] < array[minPosition]) minPosition = j;
        }
        //меняем мнимальную позицию и текущую местами
        int teporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = teporary;
    }
}
PrintArrau(arr);
SelectionSort(arr);

PrintArrau(arr);
