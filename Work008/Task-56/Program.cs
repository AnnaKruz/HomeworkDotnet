// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2 =14
// 5 9 2 3 =19
// 8 4 2 4 =18
// 5 2 6 7 =20
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void MinSumNumberArray(int[] array)
{
    int min = array[0];
    int minRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minRow = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow+1} строка");
}

int[] SumRowsArrayTwo(int[,] array)
{
    int[] newarray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        newarray[i] = sum;
    }
    return newarray;
}

void PrintArrayTwo(int[,] array)
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

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();
}

int[,] FillArray(int rows, int colums, int begin, int end)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(begin, end + 1);
        }
    }
    return array;
}

int[,] matrix = FillArray(3, 4, 0, 10);
PrintArrayTwo(matrix);
int[] sumRowsArray = SumRowsArrayTwo(matrix);
Console.WriteLine();
PrintArray(sumRowsArray);
MinSumNumberArray(sumRowsArray);