/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Enter number");
int N = int.Parse(Console.ReadLine()!);
string str = ("Even numbers: ");
for (int i = 2; i <= N; i += 2)
{
   if (i == N || i == N - 1)
   {
    str += i + ". ";
   }
   else
   {
    str += i + ", ";
   }
}

Console.WriteLine(str);