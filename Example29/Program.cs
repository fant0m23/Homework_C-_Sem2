// Напишите метод, который задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetValueUser(string message)
{
   Console.WriteLine(message);
   int value = Convert.ToInt32(Console.ReadLine());
   return value;
}
void FillArray(int[] array)
{
   int size = array.Length;
   for (int index = 0; index < size; index++)
   {
      array[index] = new Random().Next(1, 51);
   }
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
   Console.Write("]");
}

string request = "Введите количество элементов массива: ";

int size = GetValueUser(request);
int[] mass = new int[size];

FillArray(mass);
PrintArrayPretty(mass);
