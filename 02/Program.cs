// на вход принимает 2 числа и выдает, 
// какое число больше, а какое меньше.

Console.WriteLine("Введите число #1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число #2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"Большее = {numberA}");
    Console.WriteLine($"Меньшее = {numberB}");
}
else
{
    Console.WriteLine($"Большее = {numberB}");
    Console.WriteLine($"Меньшее = {numberA}");
}
