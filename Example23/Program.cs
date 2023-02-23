// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void fillArrayQrt3(double[] array, int size)
{
   int 
      index = 0;
   while (index < size)
   {
      array[index] = Math.Pow((index+1), 3);
      index++;
   }
}
void printTable(double[] array)
{
   int size = array.Length,
      index = 0;
   while (index < size)
   {
      Console.WriteLine($"{(index + 1)} x {(index + 1)} x {(index + 1)} = {array[index]}");
      index++;
   }
   Console.WriteLine();
}
void printArray(double[] array)
{
   int size = array.Length,
      index = 0;
   while (index < size)
   {
      Console.Write(array[index]);
      Console.Write("  ");
      index++;
   }
   Console.WriteLine();
}

Console.Write("Введите число: ");
int nums = Convert.ToInt32(Console.ReadLine());
double[] mass = new double[nums];
fillArrayQrt3(mass, nums);
printArray(mass);
printTable(mass);
