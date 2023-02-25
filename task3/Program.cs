// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// заполнение случайными числами массива с длиной length и значениями от 0 до maxValue
double[] GenerateArray(int length, int maxValue)
{
    Random rnd = new Random();
    double[] result = new double[length];
    for (int i=0; i < result.Length; i++)
    {
        result[i] = rnd.NextDouble() * maxValue;
    }
    return result;
}

void PrintArray(double[] array) // вывод на экран массива
{
    System.Console.Write($"[{array[0]:f2}");
    for (int i=1; i < array.Length; i++)
    {
        System.Console.Write($"; {array[i]:f2}");
    }
    System.Console.WriteLine("]");
}

(double min, double max) SearchArrayExtremum(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i=1; i < array.Length; i++)
    {
        if (max < array[i]) max = array [i];
        if (min > array[i]) min = array [i];
    }
    return (min, max);
}

int size = 5;
int maxValue = 100;
double[] myArray = new double[size];
myArray = GenerateArray(size, maxValue);
(double min, double max) extremum = SearchArrayExtremum(myArray);
PrintArray(myArray);
System.Console.WriteLine($"Разница между экстремумами массива составляет {(extremum.max - extremum.min):f2}");
