﻿// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите четверть:");
int x = Convert.ToInt32(Console.ReadLine());



if (x == 1 )
{
    Console.WriteLine("x > 0 || y >0");
}
else if (x == 2)
{
    Console.WriteLine("x < 0 && Y > 0");
}
else if (x == 3)
{
    Console.WriteLine("x < 0 && Y <0");
}
else if (x == 4)
{
    Console.WriteLine("x > 0 && Y < 0");
}
else if ( x > 4 || x <= 0)
{
    Console.WriteLine("Такой четверти нет");
}