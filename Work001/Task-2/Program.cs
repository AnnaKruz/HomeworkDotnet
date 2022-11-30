Console.Write("Ведите первое число: ");
int max = int.Parse(Console.ReadLine());
Console.Write("Ведите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (max > number2)
{
    Console.Write($"max = {max}");
}
else
{
    max = number2;
    Console.Write($"max = {max}");
}