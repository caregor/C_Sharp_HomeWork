// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Enter a 1 number: ");
int first_number    = int.Parse(Console.ReadLine());
Console.Write("Enter a 1 number: ");
int second_number   = int.Parse(Console.ReadLine());



if (first_number > second_number) 
{
    Console.WriteLine($" max = {first_number}");
    Console.WriteLine($" min = {second_number}");
}
else
{
    Console.WriteLine($" max = {second_number}");
    Console.WriteLine($" min = {first_number}");
}
