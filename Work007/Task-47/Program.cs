// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArrayTwo(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} "); 
        }
    Console.WriteLine();
    }
}

double[,] FillArray(int rows, int colums, int begin, int end)
{
    double[,] array = new double[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(begin, end))/10;
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// запрос количества строк
int rows = EnterData("Введите кочество строк: ");
// запрос количества столбцов
int colums = EnterData("Введите кочество столбцов: ");
// Создаем двухмерный массив и заполняем его случайными числами
double[,] matrix = FillArray(rows, colums, -100, 100);
// Выводим массив
PrintArrayTwo(matrix);