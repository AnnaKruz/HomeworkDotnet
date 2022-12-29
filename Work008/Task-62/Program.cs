// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void ReversArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) / 2; j++)
        {
            if (i % 2 != 0)
            {
                int temp = array[i, j];
                array[i, j] = array[i, array.GetLength(1) - j - 1];
                array[i, array.GetLength(1) - j - 1] = temp;
            }
        }
    }
}

void PrintArray(int[,] array)
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

int[,] FillArray(int begin, int end)
{
    int size = 4;
    int[,] array = new int[size, size];
    int n = 1;
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            array[i, j] = n++;
        }
    }
    return array;
}

int[,] matrix = FillArray(0, 90);
ReversArray(matrix);
PrintArray(matrix);