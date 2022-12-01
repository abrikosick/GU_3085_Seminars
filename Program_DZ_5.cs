//Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/* 
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);
    return newArray; 
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(); 
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

Console.WriteLine("Enter size of array: ");
int size_array = Convert.ToInt32(Console.ReadLine());

int[] ourArray = CreateRandomArray(size_array);
ShowArray(ourArray);
int result = Count(ourArray);
Console.WriteLine($"Count of even numbers: {result}");
 */



//Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/* 
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(); 
}

int SummUnevenNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1 )
            sum += array[i];
    return sum;
}

Console.WriteLine("Enter size of array: ");
int array_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min possible val of array: ");
int min_Value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max possible val of array: ");
int max_Value = Convert.ToInt32(Console.ReadLine());

int[] ourArray = CreateRandomArray(array_size, min_Value, max_Value);
ShowArray(ourArray);
int result = SummUnevenNum(ourArray);
Console.WriteLine($"Summ of uneven numbers is {result}");
 */



//Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    return newArray;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 2) + " ");
    Console.WriteLine(); 
}

double Diff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
            if (array[i] < min)
                min = array[i];   
        }
    double diff = max - min; 
    return diff;
}

Console.WriteLine("Enter size of array: ");
int size_array = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min possible val of array: ");
int min_Value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max possible val of array: ");
int max_Value = Convert.ToInt32(Console.ReadLine());

double[] ourArray = CreateRandomArray(size_array, min_Value, max_Value);
ShowArray(ourArray);
double result = Diff(ourArray);
Console.WriteLine($"Difference of Max and Min numbers is {result:f2}");







