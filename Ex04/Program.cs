// Напишите программу, которая принимает на вход три числа
// и выдает максимальное из этих чисел.

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

int max=num1;

if(num2>num1) max=num2;
if(num3>num2) max=num3;

Console.WriteLine($"Наибольшее число(числа): {max}");




