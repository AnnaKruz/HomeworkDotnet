// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int EnterData(string text)
{
Console.WriteLine(text);
int number = int.Parse(Console.ReadLine());
return number;
}

string FindPalindrome(int number)
{
   int number1 = number / 10000;
   int number4 = number % 10;
   int number2 = number / 1000 % 10;
   int number3 = number / 10 % 10;
   string result = "";
   if (number1 == number4 & number2 == number3) result = "это палиндром";
   else result = "это не палиндром";
   return result;   
}

int x = EnterData("Введите пятизначное число: ");

string number = FindPalindrome(x);

Console.WriteLine(number);