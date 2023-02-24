// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumOddElements(int[] array) // Сумма чисел нечетных элементов массива
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2) // начинаем с 0, т.к. это 1-й элемент массива. шаг 2
    {
        sum += array[i];
    }
    return sum;
}

int size = 6;
int minValue = -10;
int maxValue = 10;
int[] myArray = new int[size];
myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);
System.Console.WriteLine($"Сумма чисел нечетных элементов массива = {SumOddElements(myArray)}");