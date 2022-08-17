//Задача 25: Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.Write("Введите первое число A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число B: ");
int numB = int.Parse(Console.ReadLine());
int getRate(int numberA, int numberB)
{
    int totalNum = numA;
    for (int i = 1; i < numB; i++)
    {
        totalNum *= numA;
    }
    return totalNum;
}
Console.WriteLine($"Число A в степени B = {getRate(numA, numB)}");