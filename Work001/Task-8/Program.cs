Console.Write("Ведите первое число: ");
int number = int.Parse(Console.ReadLine());
int result = 2;

while (result <= number)
{
    Console.Write($"{result}, ");
    result += 2;
}
