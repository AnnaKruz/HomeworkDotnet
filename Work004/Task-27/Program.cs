// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SumNumber(int number)
{
    int res = 0;
    for(int i = 0; number > 0; i++) 
    {
        res = res + number % 10;
        number/=10;
    }
    return res;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Введите число: ");
int sum = SumNumber(a);
Console.WriteLine($"Сумма цифр числа {a} = {sum}");