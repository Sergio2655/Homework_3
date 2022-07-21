
/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Enter your number:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Enjoy:");
int count = 1;
int cube = count;
while(count <= n)
{
    cube = count * count * count;
    Console.WriteLine(cube);
    count++;
}