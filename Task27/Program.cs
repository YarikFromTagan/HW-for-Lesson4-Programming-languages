/*
Задача 27: Напишите программу, которая принимает на вход
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int NumberDigit(int s)
{
    int i = 0;
    while(s > 0)
    {
        s = s / 10;
        i ++;
    }
    return i;
}

int[] CreateArray(int s, int num)
{
    int[] arr = new int[s];
    for(int i = 0; i < s; i++)
    {
        int count = num % 10;
        arr[i] = count;
        num = num / 10;
    }

    return arr;
}

int SumNumArr(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
        sum += arr[i];
    return sum;
}

Console.Clear();
Console.Write("Введите любое целое число а = ");
int a = Convert.ToInt32(Console.ReadLine());

int size = NumberDigit(a);
int[] Array = CreateArray(size, a);

Console.WriteLine($"Сумма цифр числа {a} равна {SumNumArr(Array)}");
Console.WriteLine();


