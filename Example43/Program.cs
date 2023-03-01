// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1,   y = k2 * x + b2;     значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetValidValueFromUser(string message)
{
   Console.Write(message);
   string value = Console.ReadLine()!;
   bool valid = double.TryParse(value, out double f);
   if (valid == true) return Convert.ToDouble(value);
   else return GetValidValueFromUser(message);
}
void CrossStraight(double k1, double b1, double k2, double b2)
{
   if (k1 == k2) Console.WriteLine("Данные прямые параллельны");
   else
   {
      double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
      double y = Math.Round((x * k1 + b1), 2);
      Console.WriteLine($"Данные прямые пересекаются в точке A ({x}; {y})");
   }
}

double k1 = GetValidValueFromUser("Введите значение k1 ");
double b1 = GetValidValueFromUser("Введите значение b1 ");
double k2 = GetValidValueFromUser("Введите значение k2 ");
double b2 = GetValidValueFromUser("Введите значение b2 ");

CrossStraight(k1, b1, k2, b2);
