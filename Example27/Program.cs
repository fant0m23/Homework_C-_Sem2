// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetValueUser(string message)
{
   Console.WriteLine(message);
   int value = Convert.ToInt32(Console.ReadLine());
   return value;
}
int SumDigits(int number)
{
   int sum = 0;
   while(number>0)
   {
      sum = number % 10 + sum;
      number = number / 10;
   }
   return sum;
}

string request = "Введите число: ";

int num = GetValueUser(request);
int result = SumDigits(num);

Console.WriteLine(result);
