// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// этот код не работет:

// int [] arr={ 1, 5, 2, 4, 3, 6, 8, 7 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Lenght - 1; i++)
//     {
//         int minPosition = i;
// for (int j = i + 1; j < array.Lenght; j++)
// {
//     if(array[j] < array[minPosition]) minPosition = j;
// }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);

// Идеальное решение от GB:

// Сначала ввлд числа:
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadImput = System.Console.ReadLine();
    int result = int.Parse(ReadImput); 
    return result;
}
// метод получения случайных значений массива
int [] GenerateArray(int Lenght, int minValue, int maxValue)
{
    int [] array = new int[Lenght]; /*объявляем массив */
    Random random = new Random();
    for (int i = 0; i < Lenghth; i++)
    {
        array [i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Lenght - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); /*вывод значения массива*/

    }
    System.Console.Write($"{array[array.Lenght - 1]}");
    System.Console.WriteLine("]");
}
int Lenght = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int [] array = GenarateArray(Lenght, min, max); /*заполнение массива случайными числами*/
PrintArray(array);