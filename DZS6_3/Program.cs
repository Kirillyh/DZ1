﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int [num];
    massiv[0] = 0;
    massiv[1] = 1;
    for (int i = 2; i < massiv.Length; i++)
    {
        massiv[i] = massiv[i-1] + massiv[i-2];
    }
Console.WriteLine($"{String.Join(", " , massiv)+ "." }");

