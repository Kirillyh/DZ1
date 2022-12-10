// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a <10000 && a > 99999)
{
    Console.WriteLine("Введите пятизначное число");
}


int num1 = a / 10000;  //Находим первое число
int num4 = a / 1000%10; // Находим второе число

int num2 =a/1%10;  //Находим пятое число
int num3 = a/10%10; //Находим четвертое число

if (num1==num2 || num4==num3)
{
  Console.WriteLine("Да");  
}
else
 {
 Console.WriteLine("Нет"); 
 }
     

        //  int num2 =a/1%10;  //Находим пятое число
        //  int num3 = a/10%10; //Находим четвертое число
        //     if (num2==num3) 
        //     {
        //         Console.WriteLine("Да");
        //     }


// Console.WriteLine("Задача 19");
// Console.Write("Введите число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number){
//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");