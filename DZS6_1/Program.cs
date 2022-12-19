// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
void revers(int[]array)     // Метод для разворота массива
{
    for (int i = 0; i < array.Length / 2; i++)    //Сколько раз будет меняться наши индексы поэтому делим на 2
    {
        int temp = array[i];
        array[i]= array[array.Length - i -1];
        array[array.Length - i -1] = temp ;
    }
}
const int LENGTH = 12;   //Длина массива КОНСТАНТЫ
const int LEFTRANGE = -9;  // Промежуток от -9
const int RIGHTRANGE = 9;   // До 9

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);  // Обрашаеися к КОНСТАНТАМ 
Console.WriteLine($"[{string.Join(", ", massive)}]");             //выводим массив на экран
Console.WriteLine();
revers(massive);
Console.WriteLine($"[{string.Join(", ", massive)}]");