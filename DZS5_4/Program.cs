// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = {4, 8, 3, 2};
for (int i =0; i<array.Length; i++)
{
    array[i]=array[i]*-1;
}
Console.WriteLine(string.Join(", " ,  array));



    // int count = 0;
    // for (int i = 0; i<array.Length; i++)
    // {
    //     count = array[i];
    //     array[i] = count*-1;
    // }
    // return array;

