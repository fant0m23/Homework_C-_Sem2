// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// нельзя использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetValueUser(string message)
{
   Console.WriteLine(message);
   int value = Convert.ToInt32(Console.ReadLine());
   return value;
}
int MyMathPow(int number, int exp)
{
   int result = 1;
   for (int i = 0; i < exp; i++)
   {
      result = number * result;
   }
   return result;
}

string requestA = "Введите число A: ";
int numberA = GetValueUser(requestA);
string requestB = "Введите число B: ";
int numberB = GetValueUser(requestB);

int result = MyMathPow(numberA, numberB);
Console.WriteLine(result);
