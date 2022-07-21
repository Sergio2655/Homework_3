
/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Enter five-digit number");
int fiveDigit = int.Parse(Console.ReadLine());

checkPalindrom(fiveDigit);


void checkPalindrom(int fiveDig)
{
    int first = fiveDig / 10000;
    int second = fiveDig / 1000 % 10;
    int fifth = fiveDig % 10;
    int fourth = fiveDig % 100 / 10;
    
    if (first == fifth && second == fourth)
    {
        Console.WriteLine("It's a palindrom");
    }
    else
    {
        Console.WriteLine("Nope) Try one more time");
    }
}