// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int GetValueUser(string message)
{
   Console.Write(message);
   int value = Convert.ToInt32(Console.ReadLine());
   return value;
}
int[] NewArray(int size, int from, int to)
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
int SumOddIndex(int[] array)
{
   int summa = 0;
   for (int i = 1; i < array.Length; i += 2)
   {
      summa += array[i];
   }
   return summa;
}

int length = GetValueUser("Введите количество элементов массива: ");
int beginRange = GetValueUser("Заполнить массив элементами из диапазона от ");
int endRange = GetValueUser("до ") + 1;

int[] mass = NewArray(length, beginRange, endRange);
PrintArrayPretty(mass);
int sum = SumOddIndex(mass);
Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {sum}");
