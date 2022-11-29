/* Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 

void Digits(int num)
{
    int des = num / 10;
    int des2 = des % 10;
     
    if (num > 999 || num  < 100)
    {
        Console.Write("Вы ввели не трехзначное число");
    }
    else Console.Write($"{des2}");
}


Console.Write("Введите трехзначное число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Digits(userNum);
*/


/* Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Digits(int num)
{
    if (num < 100)
    {
        Console.Write("У вашего числа нет третьей цифры, введите другое число");
    }   
    else 
    {
        while (num > 999)
        {
            num = num / 10;
        }
        int result = num % 10;
        Console.Write($"Третья цифра вашего числа: {result} ");
    }
}   

Console.Write("Введите ваше число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Digits(userNum);
*/


/* Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. */

void Date(int num)
{
    if (num > 7 || num < 1)  Console.WriteLine("Вы ввели не тот день");
    if (num > 0 && num < 6)  Console.WriteLine("Это рабочий день");
    if (num == 6 || num == 7)  Console.WriteLine("Этот день выходной");
}

Console.Write("Введите день недели: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Date(userNum);