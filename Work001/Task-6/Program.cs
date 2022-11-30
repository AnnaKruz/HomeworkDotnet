Console.Write("Ведите первое число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.Write($"{number} - четное число");
}
else 
{
    Console.Write($"{number} - нечетное число");
}