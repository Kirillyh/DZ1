// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] array = {1,2,3,4,5};
int[] coparray = new int [array.Length];
for(int i =0; i < coparray.Length; i++)
{
    coparray[i] = array[i];
}
Console.WriteLine(string.Join("," , coparray ));