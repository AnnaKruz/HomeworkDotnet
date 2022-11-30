Console.Write("Ведите первое число: ");
int max = int.Parse(Console.ReadLine());
Console.Write("Ведите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Ведите третье число: ");
int number3 = int.Parse(Console.ReadLine());

if (max < number2)
{
    max = number2;
}
if (max < number3) 
{
    max = number3;
}

Console.Write($"max = {max}");
