// Напишите программу, которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным.

Console.WriteLine( "Введите цифру: ");
int a = int.Parse(Console.ReadLine()!);
if (a < 5)
{
     Console.WriteLine("нет");
}
else
{
    Console.WriteLine("да");
}
