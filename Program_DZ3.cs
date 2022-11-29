// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/* void Palindrom(int num)
{
    int digit2 = num / 1000 % 10;
    int digit4 = num / 10 % 10;
    int digit1 = num / 10000;
    int digit5 = num % 10;
    if (digit2 == digit4 && digit1 == digit5)
        Console.Write("It is a palindrom");
    else Console.Write("It is not a palindrom");
}

Console.WriteLine("Enter 5-zn number: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number); */




//Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/* 
double LongLine(int x1, int y1, int x2, int y2, int z1, int z2)
{
    double lengthAB = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)), 2); 
    return lengthAB;
}

Console.WriteLine("Enter X coordinat of A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y coordinat of A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z coordinat of A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter X coordinat of B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y coordinat of B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Z coordinat of B: ");
int zB = Convert.ToInt32(Console.ReadLine());


double dist = LongLine(xA, yA, xB, yB, zA, zB);
Console.WriteLine(dist); 
 */



 //Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

 void Cube(int num)
{
    int curr = 1;
    while (curr <= num)
    {
        int res = curr * curr * curr;
        Console.Write($"{res}, ");
        curr++;
    }
    Console.WriteLine($"\b\b."); 
}

Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{    Console.Write($"{number} -> ");
     Cube(number);
}
else Console.Write("Impossible number");

