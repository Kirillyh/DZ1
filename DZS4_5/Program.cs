// Домашняя работа
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
int ReadInt(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine()); 
}
int A = ReadInt("Введите число A:");
int B = ReadInt("Введите число B:");

int count = 1;
for (int i = 1; i <= B; i++ )
{
count = count * A;
}
Console.WriteLine(count);      
