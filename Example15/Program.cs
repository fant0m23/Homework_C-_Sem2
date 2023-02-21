// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool holiday(int numberOfDay)
{
   return numberOfDay < 6;
}

int day = new Random().Next(1, 8);
Console.WriteLine(day);
bool result = holiday(day);
Console.WriteLine(result);
