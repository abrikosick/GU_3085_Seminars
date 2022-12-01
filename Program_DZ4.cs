// Задача 1.  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/* 
int Stepen(int a, int b)
{
    int result = 1;
    for (int count = 0; count < b; count++)
        result *= a; 
    return result;
}

Console.WriteLine("Enter number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

while (numB < 0)
{
    Console.WriteLine("Enter Positive number B");
    numB = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(Stepen(numA, numB));
 */



// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/* 
int SumOfNumbers(int number)
{
    int sum = 0;
    while (number > 0)
        {
            sum = sum + number % 10;
            number = number / 10;    
        }
    return sum;
}

Console.WriteLine("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Summ of number {num} is " + (SumOfNumbers(num)));
 */



// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateNewArray(int size)
{
    int[] array = new int[size];  
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(0, 20);
    
    return array;
}

void ShowArray(int [] array)
{   Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b]");

}

Console.WriteLine("Enter count of elements: ");
int count_of_elem = Convert.ToInt32(Console.ReadLine());

int [] array1 = CreateNewArray(count_of_elem);
ShowArray(array1);

















































