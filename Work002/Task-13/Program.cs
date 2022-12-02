Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99) {
    while (number > 999) {
    number = number/10;
}
int result = number%10;
Console.Write($"Третья цифра в вашем числе - {result}");
}
else Console.Write("Третьей цифры нет");
