/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Enter number A");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number B");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number C");
int numberC = int.Parse(Console.ReadLine()!);
int max = numberA;

if (max < numberB)
{
    max = numberB;
}

if (max < numberC)
{
    max = numberC;
}

Console.WriteLine("Max = " + max);