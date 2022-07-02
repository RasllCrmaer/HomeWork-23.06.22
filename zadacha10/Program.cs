//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.

Console.WriteLine( "Введите число: ");
int a = int.Parse(Console.ReadLine()!);
a = a / 10;
a = a %= 10;
    Console.WriteLine(a);