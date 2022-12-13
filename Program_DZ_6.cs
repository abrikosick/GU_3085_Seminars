// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int[] CreateNewArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Enter your {i + 1} number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindCountOfMax(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }

    }
    return count;
}

Console.WriteLine("Enter count of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] Array = CreateNewArray(size);
ShowArray(Array);

int countOfMax = FindCountOfMax(Array);
Console.WriteLine($"You have entered {countOfMax} numbers > 0");
*/



//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Point (double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"({x}), ({y})");
}

Console.WriteLine("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2)
    Console.WriteLine("Lines are parallel");
else Point(k1, b1, k2, b2);




