// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CheckNumber(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) 
        {
        sum++;
        }
    }
    return sum;
}

int[] CreateMassive(int n) { 
    int[] array = new int[n]; 
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i] = GetNumber("Введите число: ");
    } 
    return array; 
} 

int GetNumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = GetNumber("Введите количесво чисел, которые хотите ввести: ");
int[] array = CreateMassive(number);
int result = CheckNumber(array);
Console.WriteLine($"[{string.Join(", " , array)}] => {result}");