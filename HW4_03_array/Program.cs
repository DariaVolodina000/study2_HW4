//  Задача 3: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции 
// (пригодится в следующих задачах).  Реализовать через функции.
//  (* Доп сложность, “введите количество элементов массива”,
//  “Введите минимальный порог случайных значений”, 
//  “Введите максимальный порог случайных значений”)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//  -> 8




void FillArrayRandom(int[] arr) // случайные числа
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }
}

void FillArraySize(int[] arr) // введите колличество эллементов массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next();
    }
}

void FillMinMax(int[] arr) // введите колличество эллементов массива, мин и макс
{
    Console.WriteLine("Введите минимальный порог случайных значений");
    int minimum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальный порог случайных значений");
    int maximum = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minimum, maximum);
    }
}

void PrintArray(int[] arr) // вывод массива на экран
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.WriteLine();
        Console.Write(arr[j]);
    }
    Console.WriteLine();
}

int[] arrayRandom = new int[8];             // рандомные числа в массиве из 8 элементов
FillArrayRandom(arrayRandom);
PrintArray(arrayRandom);
Console.WriteLine();


Console.WriteLine("Введите количество элементов массива");      // рандомные числа в массиве из заданного колличества элементов
int size = Convert.ToInt32(Console.ReadLine());
int[] arraySize = new int[size];
FillArraySize(arraySize);
PrintArray(arraySize);

Console.WriteLine();

int [] arrayMinMax = new int[8];         // рандомные числа в массиве из 8 элементов, с заданным минимальным и максимальным порогом
FillMinMax(arrayMinMax);
PrintArray(arrayMinMax);