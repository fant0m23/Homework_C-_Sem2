// Напишите программу, которая проверяет пятизначное число на палиндром.

void fillArray5digits(int[] array, int num)
{
   int index = 4;
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
int[] mass = new int[5];
fillArray5digits(mass, number);

if (mass[0]==mass[4] && mass[1]==mass[3])
{
   Console.WriteLine("Это палиндром");
}
else
{
   Console.WriteLine("Это HE палиндром");
}

