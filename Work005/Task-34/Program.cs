// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int CheckNumber(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}
int[] CreateArray(int count, int begin, int end)
{
    int[] array = new int[count];
    for(int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}
int[] array = CreateArray(4, 99, 1000);
Console.WriteLine(String.Join (" ", array));
int sum = CheckNumber(array);
Console.WriteLine($"Количество чётных чисел в массиве равно {sum}");