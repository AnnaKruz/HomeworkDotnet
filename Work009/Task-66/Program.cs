// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfNumbers(int start, int end)
{
    if (start == end+1) return 0;
    return (start + SumOfNumbers(start+1, end));
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberA = GetNumber("Введите число A: ");
int numberB = GetNumber("Введите число B: ");
Console.WriteLine(SumOfNumbers(numberA, numberB));