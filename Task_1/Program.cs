// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int first_number = 0;
int second_number = 0;

enter_number(ref first_number);
enter_number(ref second_number);

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


static void enter_number (ref int num)
{
    Console.Write("Enter a number > ");
    string inputStr = Console.ReadLine();
    num = int.Parse(inputStr);
}
