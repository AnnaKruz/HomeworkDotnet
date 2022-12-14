// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int DifferenceNumberArray(int[] array)
{
    int max = array[0];
    int min = array[0];
    int result = 0;
    for(int i = 1; i < array.Length; i++)
    {
       if(array[i] > max)
       {
        max = array[i];
       }
       if(array[i] < min)
       {
        min = array[i];
       }
      result = max - min;
    }
    return result;
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
int difference = DifferenceNumberArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {difference}");