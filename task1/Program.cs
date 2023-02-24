// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GenerateArray(int length, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[length];
    for (int i=0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

int size = 10;
int minValue = 100;
int maxValue = 1000;
int[] myArray = new int[size];
myArray = GenerateArray(size, minValue, maxValue);