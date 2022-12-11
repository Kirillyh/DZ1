// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int ReadInt(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine()); 
}
int a = ReadInt("Введите число");
int suma (int a)          //Функция которая выдаёт сумму цифр в числе.
{   
    int counter = Convert.ToString(a).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = a - a % 10;
      result = result + (a - advance);
      a = a / 10;
    }
   return result;
}

int sumaa = suma(a);
Console.WriteLine($"Сумма цифр = {sumaa}");