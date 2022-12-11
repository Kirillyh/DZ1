// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем


int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
Console.Write($"Введите элементы массива по очереди:{(i)} = ");
array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(string.Join(",", array)+".");       //Все элементы массива соединяються в строке