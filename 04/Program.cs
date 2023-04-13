// программа принимает на вход 3 числа 
// и выдает максимальное из них.

Console.WriteLine("Введите число #1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число #2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число #3: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
Console.WriteLine($"максимальное равно = {max}");