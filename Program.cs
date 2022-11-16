/*Задача 1.
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
    Console.Write($"max = {max}");
}
else
{
    Console.Write($"max = {num1}");
}
*/

/*Задача 2.
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write($"max = {max}");
*/


/*Задача 3.
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num % 2;

if (current == 0)
{
    Console.Write($"Число {num} четное");
}
else
{
    Console.Write($"Число {num} нечетное");
}
*/


/*Задача 4.
 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. */


 //

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 1;
       
while (result < num)
{
    Console.Write(result + 1 + " ");
    result = result + 2;
}
if (num <= 1)
{
    Console.Write("Введите положительное число, начиная с 2");
}    
