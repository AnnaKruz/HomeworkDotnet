// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void RandomArray(int number, int n) {
   int[] array = new int[number];
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(0,n);
   }
   Console.WriteLine($"[{string.Join(", ", array)}]");
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = GetNumber("Введите длину массива: ");
int b = GetNumber("Введите максимальное значение в индексе массива: ");
RandomArray(a, b);