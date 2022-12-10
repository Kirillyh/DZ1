// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Введите число:");

// int a = Convert.ToInt32(Console.ReadLine());

// if (a <= 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// int b = (a / 100)%10;                        // Нахождение третьей цифры в числе


// Console.WriteLine(b);

// if (a >= 100000)
// {
//     Console.WriteLine("Много цифр )");
// }

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
while (a > 1000)
{
    a = a / 10;                        //// Нахождение третьей цифры в числе
}
a = a % 10;

Console.WriteLine(a);