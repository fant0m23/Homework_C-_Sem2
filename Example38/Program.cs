// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int GetIntValueUser(string message)
{
   Console.Write(message);
   int value = Convert.ToInt32(Console.ReadLine());
   return value;
}
double[] NewArrayUser(int size, int from, int to)
{
   double[] newMass = new double[size];
   for (int i = 0; i < size; i++)
   {
      newMass[i] = new Random().Next(from, to);
   }
   return newMass;
}
double[] NewArrayRandom(int size)
{
   double[] newMass = new double[size];
   for (int i = 0; i < size; i++)
   {
      newMass[i] = new Random().NextDouble() * 100;
      newMass[i] = Math.Round(newMass[i], 2);
   }
   return newMass;
}
void PrintArrayPretty(double[] array)
{
   int size = array.Length;
   Console.Write("[");
   for (int index = 0; index < size; index++)
   {
      if (index < size - 1) Console.Write(array[index] + "  ");
      else Console.Write(array[index]);
   }
   Console.WriteLine("]");
}
double SearchMAX(double[] array)
{
   int size = array.Length;
   double currentMax = array[0];
   for (int index = 0; index < size; index++)
   {
      if (currentMax < array[index])
      {
         currentMax = array[index];
      }
   }
   return currentMax;
}
double SearchMIN(double[] array)
{
   int size = array.Length;
   double currentMin = array[0];
   for (int index = 0; index < size; index++)
   {
      if (currentMin > array[index])
      {
         currentMin = array[index];
      }
   }
   return currentMin;
}

int length = GetIntValueUser("Введите количество элементов массива: ");
int beginRange = GetIntValueUser("Заполнить массив элементами из диапазона от ");
int endRange = GetIntValueUser("до ");

double[] mass = NewArrayUser(length, beginRange, endRange);
// double[] mass = NewArrayRandom(length);
PrintArrayPretty(mass);

double max = SearchMAX(mass);
double min = SearchMIN(mass);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна {max - min}");
