// Библиотека моих методов:

// копирнуть в папку с проектом и в рабочем файле *.cs прописать в начале:
// using static MyMethods;

// для подтягивания из другой папки нужно в файле проекта *.scproj прописать:
// <ItemGroup>
//   <ProjectReference Include="..\C-sharp_Example\Example03\Library.csproj" />
// </ItemGroup>

public class MyMethods
{
   public static int GetValueUser(string message)
   {
      Console.WriteLine(message);
      int value = Convert.ToInt32(Console.ReadLine());
      return value;
   }
   public static int GetValidValueFromUser(string message)
   {
      Console.Write(message);
      string value = Console.ReadLine()!;
      bool valid = int.TryParse(value, out int f);
      if (valid == true) return Convert.ToInt32(value);
      else return GetValidValueFromUser(message);
   }
   public static int GetValueRandom(string message)
   {
      Console.WriteLine(message);
      Console.Write("от");
      int min = Convert.ToInt32(Console.ReadLine());
      Console.Write("до");
      int max = Convert.ToInt32(Console.ReadLine());
      int value = new Random().Next(min, max + 1);
      return value;
   }
   public static void FillArray(int[] array)
   {
      int size = array.Length;
      for (int index = 0; index < size; index++)
      {
         array[index] = new Random().Next(0, 10);
      }
   }
   public static void PrintArray(int[] array)
   {
      int size = array.Length;
      for (int index = 0; index < size; index++)
      {
         Console.Write(array[index] + "  ");
      }
      Console.WriteLine();
   }
   public static void MixArray(int[] array, int mixing)
   {
      int temp = 0, indexA = 0, indexB = 0,
      size = array.Length;
      for (int count = 0; count < mixing; count++)
      {
         indexA = new Random().Next(0, size);
         temp = array[indexA];
         indexB = new Random().Next(0, size);
         array[indexA] = array[indexB];
         array[indexB] = temp;
         count++;
      }
   }
   public static int searchIndexMAX(int[] array)
   {
      int index = 0,
         currentMax = array[index],
         size = array.Length,
         indexMax = 0;
      while (index < size)
      {
         if (currentMax < array[index])
         {
            currentMax = array[index];
            indexMax = index;
         }
         index++;
      }
      return indexMax;
   }
   public static int FreqCount(int[] array, int find)
   {
      int count = 0,
      size = array.Length;
      for (int index = 0; index < size; index++)
      {
         if (array[index] == find) count++;
      }
      return count;
   }
   public static string Replace(string text, char oldSymbol, char newSymbol)
   {
      string result = String.Empty;
      int size = text.Length;
      for (int i = 0; i < size; i++)
      {
         if (text[i] == oldSymbol) result = result + $"{newSymbol}";
         else result = result + $"{text[i]}";
      }
      return result;
   }
   public static void SortArray(int[] array)
   {

      for (int i = 0; i < array.Length - 1; i++)
      {
         int maxIndex = i;
         for (int j = i + 1; j < array.Length; j++)
         {
            if (array[j] > array[maxIndex]) maxIndex = j;
         }
         int temp = array[i];
         array[i] = array[maxIndex];
         array[maxIndex] = temp;
      }
   }
   public static string GetHtml(string url, string path)
   {
      string html = String.Empty;
      if (!File.Exists(path))
      {
         html = new HttpClient().GetStringAsync(url).Result;
         File.WriteAllText(path, html);
      }
      else
      {
         html = File.ReadAllText(path);
      }
      return html;
   }
   public static string PartOfText(string text, string begin, string end)
   {
      int lengthBegin = begin.Length;
      int startIndex = text.IndexOf(begin) + lengthBegin;
      int finalIndex = text.IndexOf(end);

      return text.Substring(startIndex, finalIndex - startIndex);
   }
   public static int[] NewArray(int size, int from, int to)
   {
      int[] newMass = new int[size];
      for (int i = 0; i < size; i++)
      {
         newMass[i] = new Random().Next(from, to);
      }
      return newMass;
   }
   public static void ExchangePosNegArray(int[] array)
   {
      for (int i = 0; i < array.Length; i++)
      {
         array[i] *= -1;
      }
   }
   public static int SumPos(int[] array)
   {
      int result = 0;
      for (int i = 0; i < array.Length; i++)
      {
         if (array[i] > 0) result += array[i];
      }
      return result;
   }
   public static int SumNeg(int[] array)
   {
      int result = 0;
      for (int i = 0; i < array.Length; i++)
      {
         if (array[i] < 0) result += array[i];
      }
      return result;
   }
   public static void CorrectionRange(ref int beginRange, ref int endRange)
   {
      if (beginRange > endRange)
      {
         int temp = beginRange + 1;
         beginRange = endRange - 1;
         endRange = temp;
      }
      // вызвать эту функцию: CorrectionRange(ref beginRange, ref endRange);
      // если !! int beginRange = GetValueUser("Заполнить массив элементами из диапазона от ");
      //         int endRange = GetValueUser("до ") + 1; <=== !!!
   }
   public static int[,] Create2xArray(int size0, int size1, int from, int to)
   {
      int[,] newArray = new int[size0, size1];
      for (int i = 0; i < size0; i++)
      {
         for (int j = 0; j < size1; j++)
         {
            newArray[i, j] = new Random().Next(from, to);
         }
      }
      return newArray;
   }
   public static void ShowMatrix(int[,] matrix1)
   {
      Console.WriteLine("Матрица: ");
      for (int i = 0; i < matrix1.GetLength(0); i++)
      {
         for (int j = 0; j < matrix1.GetLength(1); j++)
         {
            Console.Write($"{matrix1[i, j]} ");
         }
         Console.WriteLine();
      }
   }

}
