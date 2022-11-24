// Программа на вход принимает число и выдает, является ли оно четным

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if(num%2!=0) Console.WriteLine("Число является нечетным.");
else Console.WriteLine("Число является четным.");