﻿// Задача 4.
// Не используя рекурсию, выведите первые 
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1;

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Write("Введите число: ");
int num = Convert.ToInt32((Console.ReadLine()));


void Fibonachi(int n)
{
    int a = 0;
    int b = 1;
    Console.Write($"{a} {b} ");
    for(int i = 0; i < n - 2; i++)
    {
        int nextNum = a + b;
        a = b;
        b = nextNum;
        Console.Write($"{nextNum} ");
    }
}
Fibonachi(num);