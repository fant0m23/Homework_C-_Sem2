// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void pointNew(int[] array)
{
   Console.WriteLine("Введите имя точки: ");
   string point = Console.ReadLine()!;
   Console.Clear();
   Console.Write(point.ToUpper() + " (");
   int x = Convert.ToInt32(Console.ReadLine());
   Console.Clear();
   Console.Write($"{point.ToUpper()} ({x},");
   int y = Convert.ToInt32(Console.ReadLine());
   Console.Clear();
   Console.Write($"{point.ToUpper()} ({x},{y},");
   int z = Convert.ToInt32(Console.ReadLine());
   Console.Clear();
   Console.WriteLine($"{point.ToUpper()} ({x},{y},{z})");
   array[0] = x;
   array[1] = y;
   array[2] = z;
}
double distance(int offsetX, int offsetY, int offsetZ)
{
   return Math.Round(Math.Sqrt(Math.Pow(offsetZ, 2) + Math.Pow(offsetY, 2) + Math.Pow(offsetX, 2)),2);
}

int[] point1 = new int[3];
int[] point2 = new int[3];
pointNew(point1);
pointNew(point2);

int difX = point1[0] - point2[0];
int difY = point1[1] - point2[1];
int difZ = point1[2] - point2[2];
double length = distance(difX, difY, difZ);
Console.WriteLine("Расстояние между точками в пространстве равно " + length);
