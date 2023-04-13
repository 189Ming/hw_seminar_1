// программа, которая на вход принимает
// число N, а на выходе показывает все четные числа от 1 до N.


Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
Console.Write("четные числа: ");
while (count <= number)
{
    Console.Write(count + " ");
    count += 2;
}