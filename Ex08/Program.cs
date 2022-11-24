// Программа принимает число и на выходе показывает все четные
// от 1 до N

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.Write($"{num} -> ");
int i=2;

while(i<=num)
{
    if(i%2==0) Console.Write($" {i} ");
    i++;
}