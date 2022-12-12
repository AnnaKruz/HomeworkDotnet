// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B (без использования Math.Pow).
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int DegreeNumbers(int number1, int number2)
{
    int res = number1;
    for(int i = 1; i < number2; i++) 
    {
        res = res * number1;
    }
    return res;
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Введите число 1: ");
int b = GetNumber("Введите число 2: ");
int s = DegreeNumbers(a, b);
Console.WriteLine($"Число {a} в стени {b} = {s}");