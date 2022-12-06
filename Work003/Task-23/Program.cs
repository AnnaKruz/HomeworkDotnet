// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void TableCube(int n) {
    int i = 1;
    while (i <= n){
        int result = i*i*i;
        Console.Write($"{result}, ");
        i++;
    }
}

int EnterData(string text)
{
Console.WriteLine(text);
int number = int.Parse(Console.ReadLine());
return number;
}

int number = EnterData("Введите число ");
TableCube(number);