// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите числа через запятую: ");
string? input = Console.ReadLine();                 // Обработаю налл
int[] numbers = ParseStringToArray(input);
PrintArray(numbers);
 
int Comparison(int[] Numbers)             // Сколько чисел больше нуля
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if(Numbers[i] > 0 ) count += 1;       // Увеличиваем на 1
  }
  return count;
}
 
Console.WriteLine($"Введено чисел больше нуля >> {Comparison(numbers)} "); // Выводим на экран сколько чисел больше нуля в массиве number

int[] ParseStringToArray(string input)          // Разобрать строку в массив
{
    int countNumbers = GetCountNumbersInString(input);  // создаем переменную которая равна количеству чифр в методе GetCountNumbersInString
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            substring += input[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;
        }
    }
    if(input[input.Length - 1] != ',')
        numbers[indexNumber] = Convert.ToInt32(substring);
    return numbers;
}
int GetCountNumbersInString(string input)   // Получить количество чифр в строке
{
    int count;
    if(input[input.Length - 1] == ',')
        count = 0;
    else
        count = 1;

    for(int i = 0; i < input.Length; i++)
    {
        if(input[i] == ',')
            count++;
    }
    return count;
}

void PrintArray(int[] array)              // Метод печатает массив
{
    
    
    for (int i = 0; i < array.Length; i++)
    {   
    
        Console.Write(array[i] + " ");
    }
}