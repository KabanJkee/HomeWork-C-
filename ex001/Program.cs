﻿/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine();
int A = int.Parse(number1);

Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine();
int B = int.Parse(number2);

if (A>B)
{
    Console.WriteLine($"Максимальное число {A}");
}
else
{
    Console.WriteLine($"Максимальное число {B}");
}