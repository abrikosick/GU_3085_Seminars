// Задача 1. Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/* 
int[,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i, j] = new Random().Next(minVal, maxVal + 1);
            Console.WriteLine();

    return created2dArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Sort(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int count = 0; count < array.GetLength(1) - 1; count++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
    return array;
}

Console.WriteLine("Enter count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int [,] ourArray = Create2dArray(rows, columns, minVal, maxVal);
Show2dArray(ourArray);
Show2dArray(Sort(ourArray));
 */



// Задача 2. Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/* 
int[,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i, j] = new Random().Next(minVal, maxVal + 1);
    Console.WriteLine();
    return created2dArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMinRow(int[,] array)
{
    int sumMin = 0;
    int temp = 0;
    int minRow = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumMin += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (sumMin > temp)
        {
            sumMin = temp;
            minRow = i;
        }


    }
    return minRow;
}

Console.WriteLine("Enter count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[,] ourArray = Create2dArray(rows, columns, minVal, maxVal);
Show2dArray(ourArray);
int minRow = FindMinRow(ourArray);
Console.WriteLine($"{minRow + 1} row");
 */


// Задача 3. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] Create2dArray()
{
    int[,] created2dArray = new int[4, 4];
    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 3; j++)
            created2dArray[i, j] = new Random().Next(1, 30 + 1);
    return created2dArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Fill2dArraySpiral(int[,] array)
{ 
    //array[0,0] = 1;
    //array[0,1] = 2;
    //array[0,2] = 3;
    //array[0,3] = 4;
    int count = 1;
    for(int i = 0 ; i < 4 ; i++)
    {
        array[0, i] = count;
        count++;
    }
    //array[1,3] = 5;
    //array[2,3] = 6;
    //array[3,3] = 7;
    for(int i = 1 ; i < 4 ; i++)
    {
        array[i, 3] = count;
        count++;
    }

    //array[3,2] = 8;
    //array[3,1] = 9;
    //array[3,0] = 10;
    for(int i = 2 ; i >= 0 ; i--)
    {
        array[3, i] = count;
        count++;
    }   
    array[2,0] = 11;
    array[1,0] = 12;
    array[1,1] = 13;
    array[1,2] = 14;
    array[2,2] = 15;
    array[2,1] = 16;
    return array;
}
int [,] newArray = Create2dArray();
Show2dArray(Fill2dArraySpiral(newArray));