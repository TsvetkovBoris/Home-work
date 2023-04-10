// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int[] GetArray()
{
  int size = 12;
  int[] arr = new int [size];
  Random rand = new Random();
  for (int i = 0; i < size; i++)
  {
    arr[i] = rand.Next(100, 1000);
    Console.Write(arr[i] + " ");
  }
  return arr;
}

int FindEven(int[] arr, int count, int size)
{
  for(int i = 0; i < size; i++)
  {
    if (arr[i] % 2 == 0)
      count++;
  }
  Console.WriteLine("\nКоличество четных чисел в массиве = " + count);
return count;
}
int[] arr = GetArray();
FindEven(arr, 0, 12);