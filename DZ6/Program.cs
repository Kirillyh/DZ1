﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите числоN:");
int N = Convert.ToInt32(Console.ReadLine());   
for (int i=0; i <= N; i = i +2)               //Цикл for: int i=0 Это счетчик откуда будет начинаться i <= N остановка счетчика i = i +2 через какой шаг будет идти счетчик
{                                             
    Console.WriteLine(i + " ");
}

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите числоN:");
// int N = Convert.ToInt32(Console.ReadLine());   
// for (int i=-N; i <= N; i = i++)               //Цикл for: int i=-N Это счетчик откуда будет начинаться i <= N остановка счетчика i++ через какой шаг будет идти счетчик
// {                                             
//     Console.WriteLine(i + " ");
// }