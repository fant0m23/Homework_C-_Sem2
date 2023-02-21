// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int a1 = new Random().Next(-10, 11);
int b1 = new Random().Next(-10, 11);
int c1 = new Random().Next(-10, 11);
int a2 = new Random().Next(-10, 11);
int b2 = new Random().Next(-10, 11);
int c2 = new Random().Next(-10, 11);
Console.Write($"A ({a1},{b1},{c1})");
Console.WriteLine();
Console.Write($"B ({a2},{b2},{c2})");
Console.WriteLine();

a1 = a1 - a2;
a2 = 0;
b1 = b1 - b2;
b2 = 0;

Console.Write($"A ({a1},{b1},{c1})");
Console.WriteLine();
Console.Write($"B ({a2},{b2},{c2})");
Console.WriteLine();


double hypotenuse1 = Math.Round(Math.Sqrt(Math.Pow((c1-c2), 2) + Math.Pow(b1, 2)),2);
Console.WriteLine(hypotenuse1);
double hypotenuse2 = Math.Round(Math.Sqrt(Math.Pow(hypotenuse1, 2) + Math.Pow(a1, 2)),2);
Console.WriteLine(hypotenuse2);




// int dev = Math.Abs(a1 - a2);
// Console.WriteLine(dev);
// int offsetX1(int x1, int x2)
