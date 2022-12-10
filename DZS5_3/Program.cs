// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadInt(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine()); 
}

int res (int number)
{
    int result = 1;
    for (int i = 1; i <= number;i++)
    {
        result *= i;  //result=result*i
    }
    return result;
}
int A = ReadInt("Введите число:  ");  //обрашаемся к методу
int result = res(A);      
Console.WriteLine($"Произведение{A}={result}");