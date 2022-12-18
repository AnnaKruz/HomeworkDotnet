// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void IntersectionTwoSpheres (double b1, double k1, double b2, double k2)
{
    double x = (b2-b1)/(k1-k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    if (y1 == y2)
    {
        Console.Write($"({x}; {y1})"); 
    }
    else {
        Console.Write("Прямые не пересекаются");    
    }
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int b1 = GetNumber("Введите число b1: ");
int k1 = GetNumber("Введите число k1: ");
int b2 = GetNumber("Введите число b2: ");
int k2 = GetNumber("Введите число k2: ");

IntersectionTwoSpheres(b1, k1, b2, k2);