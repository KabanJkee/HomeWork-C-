/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine();
int x = int.Parse(number1);

Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine();
int y = int.Parse(number2);

Console.WriteLine("Введите третье число");
string number3 = Console.ReadLine();
int z = int.Parse(number3);
int max = x;
if (y>max)
{
    max = y;
}
if (z>max)
{
    max = z;
}
Console.WriteLine($"Максимальное число = {max}");