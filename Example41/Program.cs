// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] NewArray(string msg)
{
   int[] newMass = new int[1000];
   string stop = "!";
   for (int i = 0; i < newMass.Length; i++)
   {
      Console.Write(msg);
      string flag = Console.ReadLine()!;
      bool valid = int.TryParse(flag, out int f);
      if (stop == flag) break;
      else if (valid == true) newMass[i] = Convert.ToInt32(flag);
      else continue;
   }
   return newMass;
}
int PositiveCount(int[] array)
{
   int count = 0,
   size = array.Length;
   for (int index = 0; index < size; index++)
   {
      if (array[index] > 0) count++;
   }
   return count;
}

string message = "Вводите множество чисел (для окончания ввода введите !)  ";
int[] mass = NewArray(message);
int result = PositiveCount(mass);
Console.WriteLine($"Из введённого множества чисел {result} больше нуля");
