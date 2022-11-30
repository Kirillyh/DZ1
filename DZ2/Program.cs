// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня:"); 

string a = Console.ReadLine();   // считываем с консоли переменную a

int b =  Convert.ToInt32(a);     //создаем переменную конвентируем переменную a

if (b == 1)
{
Console.WriteLine("Понедельник");
}
if (b==2)
{
    Console.WriteLine("Вторник");
}
if (b==3)
{
    Console.WriteLine("Среда");
}
if (b==4)
{
    Console.WriteLine("Четверг");
}
if (b==5)
{
    Console.WriteLine("Пятница");
}
if (b==6)
{
    Console.WriteLine("Суббота");
}
if (b==7)
{
    Console.WriteLine("Воскресенье");
}
if (b>7||b<1)                //Условие мы попадаем в это условие Console.WriteLine("Какой сегодня день:");
{
    Console.WriteLine("Какой сегодня день:");
} 
