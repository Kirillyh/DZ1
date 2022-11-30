// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Вывести на экран два числа:");

Console.WriteLine("Первое число:");
int a = Convert.ToInt32(Console.Read());
Console.WriteLine("Второе число:");
int b = Convert.ToInt32(Console.Read());
int max = a;
if (a > b) max = a;
{
  Console.WriteLine("max = a");
}
Console.WriteLine("Второе число:");

if (a>b) max = b;
{
    Console.WriteLine("min = b");
}
