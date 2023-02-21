// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int countDigits(int num)
{
   int count = 0;
   while (num > 0)
   {
      num = num / 10;
      count++;
   }
   return count;
   // return (int)Math.Log10(num) + 1;
}
void fillWithNumbers(int[] array, int size, int num)
{
   int index = size - 1;
   while (index >= 0)
   {
      array[index] = num % 10;
      num = num / 10;
      index -= 1;
   }
}

Console.WriteLine("Введите число (не более 2 147 000 000): ");
int number = Convert.ToInt32(Console.ReadLine());
// int number = new Random().Next(100, 2147483647);
// Console.WriteLine(number);
int lenght = countDigits(number);

if (number > 99)
{
   int[] mass = new int[lenght];
   fillWithNumbers(mass, lenght, number);
   Console.WriteLine(mass[2]);
}
else
{
   Console.WriteLine("Третьей цифры нет");
}
