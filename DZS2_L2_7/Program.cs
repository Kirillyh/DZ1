// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число:");

int a = Convert.ToInt32(Console.ReadLine());

if (a > 7 || a == 0)
{
    Console.WriteLine("Не верное число");
}

int b = a * 0 + 6;
int c = a * 0 + 7;
if (a == b)
{
    Console.WriteLine("Да");
}
if (a==c)
{
    Console.WriteLine("Да");
}
if (a <= 5)
{
    Console.WriteLine("Нет");
}