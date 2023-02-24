// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GenerateArray(int length, int minValue, int maxValue) // заполнение случайными числами массива с заданными характеристиками
{
    Random rnd = new Random();
    int[] result = new int[length];
    for (int i=0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] array) // вывод на экран массива
{
    System.Console.Write($"[{array[0]}");
    for (int i=1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine("]");
}

int CountPositiveNumbersInArray(int[] array) // подсчет четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int size = 10;
int minValue = 100;
int maxValue = 1000;
int[] myArray = new int[size];
myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);
System.Console.WriteLine($"Количество положительных чисел в массиве = {CountPositiveNumbersInArray(myArray)}");