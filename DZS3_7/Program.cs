﻿// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты x1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y22:");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)+Math.Pow(z1-z2, 2));  // Формула AB = Формула AB = КОРЕНЬ (Xb - Xa)2 + (Yb - Ya)2 + (Zb _ Za)2
  Console.WriteLine($"Итог{res:f2}");