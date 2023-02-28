// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int GetValueUser(string message)
{
   Console.Write(message);
   int value = Convert.ToInt32(Console.ReadLine());
   return value;
}
int[] NewRandomArray(int size, int from, int to)
{
   int[] newMass = new int[size];
   for (int i = 0; i < size; i++)
   {
      newMass[i] = new Random().Next(from, to);
   }
   return newMass;
}
void PrintArrayPretty(int[] array)
{
   int size = array.Length;
   Console.Write("[");
   for (int index = 0; index < size; index++)
   {
      if (index < size - 1) Console.Write(array[index] + ", ");
      else Console.Write(array[index]);
   }
   Console.WriteLine("]");
}
int CountEven(int[] array)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] % 2 == 0) count++;
   }
   return count;
}

int length = GetValueUser("Введите количество элементов массива: ");
int[] mass = NewRandomArray(length, 100, 1000);

PrintArrayPretty(mass);
int result = CountEven(mass);
Console.WriteLine($"Чётных элементов в массиве {result}");