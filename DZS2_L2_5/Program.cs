// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


Console.WriteLine("Введите первое число:");
int numbera = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int numberb = Convert.ToInt32(Console.ReadLine());

if (numbera * numbera == numberb || numberb * numberb == numbera)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
