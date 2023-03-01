// семинар 5: печать в ФАЙЛ от Сергея К.

https://learn.microsoft.com/ru-RU/dotnet/api/system.io.streamwriter?view=net-6.0
StreamWriter sw = new StreamWriter("CDriveDirs.txt.csv");

sw.Write("11;");
sw.Write("12;");
sw.WriteLine("13;");

sw.Write("21;");
sw.Write("22;");
sw.WriteLine("23;");

sw.Close();

https://learn.microsoft.com/ru-ru/dotnet/api/system.io.streamreader?view=net-7.0
using StreamReader sr = new StreamReader("CDriveDirs.txt.csv");

while (!sr.EndOfStream)
{
  string[] elements = sr.ReadLine()!
                        .Split(new char[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

  for (int i = 0; i < elements.Length; i++)
  {
    Console.Write($" >>>{elements[i]}<<< ");
  }
  Console.WriteLine();
}
