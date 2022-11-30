// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число:");           // выводим на экран 
int numberA = Convert.ToInt32(Console.ReadLine());    // создаем переменную конвентируем со строки в цифру


Console.WriteLine("Введите второе число:");            //выводим второе цисло
int numberB = Convert.ToInt32(Console.ReadLine());     //создаем переменную конвентируем выводим с консоли
if (numberB * numberB == numberA)                      //если numberB * numberB == numberA
{          
    Console.WriteLine("да");                           //тогда выводим на экран да
}
else                                                  //если нет 

Console.WriteLine("нет");                              //выводим на экран нет