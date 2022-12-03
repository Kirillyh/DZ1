// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число:");            
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA % numberB == 0)              //Ищем кратно или нет
{
    Console.WriteLine("Кратно");
}
    else 
    {
    int n = numberA % numberB;                // НАходим остаток 
   Console.WriteLine($"Не кратно, остаток{n}");
    }