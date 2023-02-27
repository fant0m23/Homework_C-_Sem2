// Библиотека моих методов:

// копирнуть в папку с проектом и в рабочем файле *.cs прописать в начале:
// using static MyMethods;
public class MyMethods
{
   public static int GetValueUser(string message)
   {
      Console.WriteLine(message);
      int value = Convert.ToInt32(Console.ReadLine());
      return value;
   }
   public static int GetValueRandom(string message)
   {
      Console.WriteLine(message);
      Console.Write("от");
      int min = Convert.ToInt32(Console.ReadLine());
      Console.Write("до");
      int max = Convert.ToInt32(Console.ReadLine());
      int value = new Random().Next(min, max+1);
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
      int startIndex = text.IndexOf(begin) + begin.Length;
      int finalIndex = text.IndexOf(end);
      return text.Substring(startIndex, finalIndex - startIndex);
   }


}
