// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int GetValidValueFromUser(string message)
{
   Console.Write(message);
   string value = Console.ReadLine()!;
   bool valid = int.TryParse(value, out int f);
   if (valid == true) return Convert.ToInt32(value);
   else return GetValidValueFromUser(message);
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

int[] mass = NewArray(length, beginRange, endRange);
PrintArrayPretty(mass);
int sum = SumOddIndex(mass);
Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {sum}");
