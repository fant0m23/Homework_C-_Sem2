//   Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

void FillArray5digits(int[] array, int num)
{
   int index = array.Length - 1;
   while (index >= 0)
   {
      array[index] = num % 10;
      num = num / 10;
      index -= 1;
   }
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// int number = new Random().Next(10000, 100000);
// Console.WriteLine(number);
if (number<10000 || number>99999)
{
   Console.WriteLine("Число не пятизначное, попробуйте ещё раз");
}

int[] mass = new int[5];
FillArray5digits(mass, number);

if (mass[0] == mass[4] && mass[1] == mass[3])
{
   Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет");
}