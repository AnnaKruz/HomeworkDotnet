// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void SearchPosition(int[,] array, int rows, int colums)
{
    {
        bool position = false;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == rows & j == colums)
                {
                    position = true;
                    break;
                }
            }
        }
        if (position == false) Console.WriteLine($"элемента {rows}, {colums} -> в массиве нет");
        else Console.WriteLine($"элемент {rows}, {colums} в массиве есть");
    }
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

int rows = new Random().Next(1, 10);
int colums = new Random().Next(1, 10);
int[,] matrix = FillArray(rows, colums, -10, 100);
PrintArrayTwo(matrix);
SearchPosition(matrix, 1, 7);