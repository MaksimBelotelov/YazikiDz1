﻿// Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());

if(num1>num2) 
{
    Console.WriteLine("Наибольшее число: "+num1);
    Console.WriteLine("Наименьшее число: "+num2);
}
else if(num2>num1)
{
    Console.WriteLine("Наибольшее число: "+num2);
    Console.WriteLine("Наименьшее число: "+num1);
}
else
    Console.WriteLine("Числа равны");