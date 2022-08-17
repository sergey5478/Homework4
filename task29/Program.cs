/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
(на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] arr = new int[8];
void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int value = new Random().Next(1, 100);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}
RandomArray(arr);