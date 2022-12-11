// int a = 12345;
// int b = a / 1000%10;
// Console.WriteLine(b);
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
Console.WriteLine(count);               // return count;

// Console.WriteLine(count);