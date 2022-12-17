// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetRandomArray(int length, int leftRange, int rightRange)  //Метод который возврашает массив случайными целыми чмслами
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

// 1. сумма положительных элементов
// 2. сумма отрицательных элементов
(int, int) SumPositiveAndNegative(int[] array)  // Возвратить два челых числа КОРТЕЖ
{
    int sumPositive = 0;
    int sumNegative = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) //если элемент положительный
        {
            sumPositive += array[i]; //копить положительную сумму
        }
        else //иначе элемент отрицательный (или == 0)
        {
            sumNegative += array[i]; // копить отрицательную сумму
        }
    }
    return (sumPositive, sumNegative);  // Возврашаем сумму положительных и отрицательных чисел
}

const int LENGTH = 12;   //Длина массива КОНСТАНТЫ
const int LEFTRANGE = -9;  // Промежуток от -9
const int RIGHTRANGE = 9;   // До 9

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);  // Обрашаеися к КОНСТАНТАМ 
Console.WriteLine($"{string.Join(", ", massive)}");             //выводим массив на экран
(int sumP, int sumN) = SumPositiveAndNegative(massive);            //Получаем сумму положительных и отрицательных чифр через метод КОРТЕЖ
Console.WriteLine($"Сумма положительных элементов = {sumP}, отрицательных = {sumN}");  