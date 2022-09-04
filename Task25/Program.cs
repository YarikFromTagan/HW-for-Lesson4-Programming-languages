/*
Задача 25: 
Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Pow(int osn, int pok)
{
    int result = 1;
    for( int i = 0; i < pok; i++) result = result * osn;
    return result;
}

Console.Clear();

Console.Write("Для возведения числа а в степень b введите а = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Для возведения числа а в степень b введите b = ");
int b = Convert.ToInt32(Console.ReadLine());


int res = Pow(a, b);

Console.WriteLine();
Console.WriteLine($"{a} в степени {b}  равно {res}");
Console.WriteLine();
