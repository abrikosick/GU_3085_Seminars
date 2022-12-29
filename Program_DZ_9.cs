// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
/* 
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNumbers(n - 1);
}
Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number); */


// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/* 
int SumNumbers(int m, int n, int summ)
{
    if (Math.Max(n, m) != Math.Min(n, m))
    {
        summ += Math.Max(n, m);
        return SumNumbers(Math.Max(n, m) - 1, Math.Min(n, m), summ);
    }
    else return summ + Math.Min(n, m);
}
Console.WriteLine("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(m, n, 0)); */


// Задача 3. Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную

string BinarSyst(int num, string binResult)
{
    if (num != 0)
    {
        binResult = num % 2 + binResult;
        return BinarSyst(num / 2, binResult);
    }
    return binResult;
}
Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

string binResult = string.Empty;
string res = BinarSyst(number, binResult);
Console.WriteLine($"Your number {number} in binar syst is {res}");


