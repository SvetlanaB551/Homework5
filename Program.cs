// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


void PrintArray(string msg, int[] array)
{
    Console.Write(msg + "[");

    for (int i = 0; i < array.Length - 1;  i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine(array[array.Length - 1] + "]");
}


int[] CreateArr(int size)
{
    int[] result = new int [size];

    for (int i = 0; i < size; ++i)
        result[i] = new Random().Next(99, 1000);

    return result;
}

int DigCount(int[] array)
{
    int result = 0;

    foreach(int item in array)
        if (item % 2 == 0)
            ++result;

    return result;
}

void Ex34()
{
    int size = ReadData("Введите размер массива: ");
    int[] array = CreateArr(size);
    PrintArray("Полученный массив:", array);
    Console.WriteLine("Количество чётных чисел в массиве: " + DigCount(array));
}

Ex34();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void Ex36()
{
int n, sum = 0;
int[] a;

Console.Write("Введите количество элементов массива: ");
n = int.Parse(Console.ReadLine());
a = new int[n];
Console.WriteLine("Массив:");
for (int i = 0; i < n; i++)
{
    a[i] = new Random().Next(1, 10);
    Console.Write($" {a[i]}");
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    if ((i+1) % 2 == 0)
        sum = sum + a[i];
}
Console.WriteLine("Сумма элементов с четными номерами: {0} ", sum);
}
Ex36();

// Задача 38
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
//
// [3 7 22 2 78] -> 76

double[] CreateArr1(int size)
{
    double[] result = new double[size];
    Random generator = new Random();

    for (int i = 0; i < size; ++i)
        result[i] = generator.NextDouble() * generator.Next(-100, 100);

    return result;
}

void PrintArr(string msg, double[] array)
{
    Console.Write(msg + "[");

    for (int i = 0; i < array.Length - 1; i++)
        Console.Write("{0:F2}, ", array[i]);

    Console.WriteLine("{0:F2}]", array[array.Length - 1]);
}

double FindMax(double[] array)
{
    double max = double.MinValue;

    foreach (double item in array)
        if (item > max)
            max = item;

    return max;
}

double FindMin(double[] array)
{
    double min = double.MaxValue;

    foreach (double item in array)
        if (item < min)
            min = item;

    return min;
}

void Ex38()
{
    int size = ReadData("Введите длину массива: ");
    double[] array = CreateArr1(size);
    PrintArr(" ", array);
    double max = FindMax(array);
    double min = FindMin(array);
    Console.WriteLine("max = : {0:F2}", max);
    Console.WriteLine("min =: {0:F2}", min);
    Console.WriteLine("min - max=: {0:F2}", max - min);
}
Ex38();