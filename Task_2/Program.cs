// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.Write("Enter a 1 number > ");
int first_number = int.Parse(Console.ReadLine());

Console.Write("Enter a 2 number > ");
int second_number = int.Parse(Console.ReadLine());

Console.Write("Enter a 3 number > ");
int third_number = int.Parse(Console.ReadLine());

// condition for 1 number
if ((first_number > second_number) & (first_number > third_number))
{
    Console.WriteLine($"Numbers {first_number}, {second_number}, {third_number} max -> {first_number}");
}

// condition for 2 number
if ((first_number < second_number) & (second_number > third_number))
{
    Console.WriteLine($"Numbers {first_number}, {second_number}, {third_number} max -> {second_number}");
}

// condition for 3 number
if ((third_number > second_number) & (first_number < third_number))
{
    Console.WriteLine($"Numbers {first_number}, {second_number}, {third_number} max -> {third_number}");
}