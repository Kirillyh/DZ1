// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

    Console.WriteLine(max);

// if (a > c);
// {
//     Console.WriteLine(a);
// }



// if (max > b) max = a;
// if (max > c) max = a;
// Console.WriteLine("a");