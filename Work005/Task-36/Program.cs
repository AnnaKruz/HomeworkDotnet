// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int CheckNumber(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i=i+2)
    {
    sum = sum + array[i];    
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
int[] array = CreateArray(6, -9, 10);
Console.WriteLine(String.Join (" ", array));
int sum = CheckNumber(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");