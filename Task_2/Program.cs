/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Enter number A");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number B");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA < numberB)
{
    Console.WriteLine("The larger number equals: " + numberB);
}

else if (numberA == numberB)
{
    Console.WriteLine("Entered numbers are equal");
}

else 

{
    Console.WriteLine("The larger number equals: " + numberA);
}