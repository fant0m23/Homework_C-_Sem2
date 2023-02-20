// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int secondOf3(int numeral)
{
   return (numeral % 100) / 10;
}

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>99 && number<1000)
{
   int result = secondOf3(number);
   Console.WriteLine(result);
}
else
{
   Console.WriteLine("Число не трёхзначное");
}

// с использованием Random:
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
Console.WriteLine(secondOf3(num));
