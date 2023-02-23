// Дан массив наполненый числами от 1 до N.
// Задача: сколько раз какое число встречается (построить частотный словарь)

// 1 3 1 2 1 2 4 5 1 2 5 4

// 1 - 4р
// 2 - 3р
// 3 - 1р
// 4 - 2р
// 5 - 2р

int Request(string message)
{
   Console.WriteLine(message);
   int value = Convert.ToInt32(Console.ReadLine());
   return value;
}
void FillArray(int[] array, int end)
{
   int size = array.Length;
   for (int index = 0; index < size; index++)
   {
      array[index] = new Random().Next(1, end + 1);
   }
}
void PrintArray(int[] array)
{
   int size = array.Length;
   for (int index = 0; index < size; index++)
   {
      Console.Write(array[index] + "  ");
   }
   Console.WriteLine();
}
int FreqCount(int[] array, int find)
{
   int count = 0,
      size = array.Length;
   for (int index = 0; index < size; index++)
   {
      if (array[index] == find) count++;
   }
   return count;
}

string msg1 = "Введите размер массива: ";
int length = Request(msg1);
int[] mass = new int[length];
string msg2 = "Массив наполнен числами от 1 до  ";
int lot = Request(msg2);

FillArray(mass, lot);
PrintArray(mass);

for (int numbers = 1; numbers <= lot; numbers++)
{
   Console.WriteLine(numbers + " - " + FreqCount(mass, numbers) + " p");
}