/*
Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] InputArray(int num)
{
    int[] arr = new int[num];
    for(int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i} элемент ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
        Console.WriteLine("\b\b]");
        Console.WriteLine();
}

Console.Clear();
Console.Write("Подскажите размерность массива, который Вы хотите создать N = ");
int n = Convert.ToInt32(Console.ReadLine());

int[] Array = InputArray(n);

Console.WriteLine();
Console.Write("Вы создали массив Array");
PrintArray(Array);