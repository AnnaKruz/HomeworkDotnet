Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 7 || number == 6) Console.Write("да, это выходной");
if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5) Console.Write("не является выходным");
if (number > 7) Console.Write("нет такого дня");