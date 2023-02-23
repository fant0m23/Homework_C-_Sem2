// Реализовать перемешивание массива

int Request(string message)
{
   Console.WriteLine(message);
   int value = Convert.ToInt32(Console.ReadLine());
   return value;
}
void FillArray(int[] array)
{
   int size = array.Length;
   for (int index = 0; index < size; index++)
   {
      array[index] = new Random().Next(0, 10);
   }     
}
void PrintArray(int[] array)
{
   int size = array.Length;
   for (int index = 0; index < size; index++)
   {
      Console.Write(array[index] + "  ");
   }
   Console.WriteLine();
}
void MixArray(int[] array, int mixing)
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

string msg1 = "Введите размер массива: ";
int length = Request(msg1);
int[] mass = new int[length];
string msg2 = "Введите количество перестановок элементов массива: ";
int lotsMixing = Request(msg2);

FillArray(mass);
PrintArray(mass);
MixArray(mass, lotsMixing);
PrintArray(mass);
