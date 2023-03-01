// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int GetValidValueFromUser(string message)
{
   Console.Write(message);
   string value = Console.ReadLine()!;
   bool valid = int.TryParse(value, out int f);
   if (valid == true) return Convert.ToInt32(value);
   else return GetValidValueFromUser(message);
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
void CorrectionRange(ref int beginRange, ref int endRange)
{
   if (beginRange > endRange)
   {
      int temp = beginRange + 1;
      beginRange = endRange - 1;
      endRange = temp;
   }
}

int length = GetValidValueFromUser("Введите количество элементов массива: ");
int beginRange = GetValidValueFromUser("Заполнить массив элементами из диапазона от ");
int endRange = GetValidValueFromUser("до ") + 1;
CorrectionRange(ref beginRange, ref endRange);

double[] mass = NewArrayUser(length, beginRange, endRange);
// double[] mass = NewArrayRandom(length);
PrintArrayPretty(mass);

double max = SearchMAX(mass);
double min = SearchMIN(mass);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна {max - min}");
