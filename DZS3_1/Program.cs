// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координаты:");

int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты:");

int Y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && Y > 0)
{
    Console.WriteLine("В первой четверти");
}
else if (x < 0 && Y > 0)
{
    Console.WriteLine("Во второй четверти");
}
else if (x < 0 && Y <0)
{
    Console.WriteLine("В третьей четверти");
}
else if (x > 0 && Y < 0)
{
    Console.WriteLine("В четвертой четверти");
}