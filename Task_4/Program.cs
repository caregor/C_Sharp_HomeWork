/* Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */
int tmp = 0;
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"{number} - > ");
for (int i = 0; i < number / 2; i++)
{
    Console.Write($" {tmp= tmp + 2 } ");
}
Console.WriteLine();