

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Enter x1 coordinate:");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y1 coordinate:");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z1 coordinate:");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter x2 coordinate:");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y2 coordinate:");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z2 coordinate:");
int z2 = int.Parse(Console.ReadLine());

int x3 = (x2 - x1)*(x2 -x1);
int y3 = (y2-y1)*(y2-y1);
int z3 = (z2-z1)*(z2-z1);
double distance = Math.Sqrt(x3+y3+z3);
Console.WriteLine(distance);