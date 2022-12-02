Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int result = number / 10 % 10;
Console.Write($"Вторая цыфра в числе {number} - {result});

