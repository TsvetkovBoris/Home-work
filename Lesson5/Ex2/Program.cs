// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях 

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetArr(int size)
{
  int[] array = new int [size];
  Random rand = new Random();
  for (int i = 0; i < size; i++)
  {
    array[i] = rand.Next(100);
    Console.Write(array[i] + " ");
  }
  return array;
}

int FindSumm(int[] array)
{
   int summ = 0;
  for (int i = 0; i < size; i++)
  {
    if (i % 2 == 1)
      summ += array[i];
  }
  Console.WriteLine($"\nСумма Элементов массива = {summ}");
  return summ;
}

int[] arr = GetArr(size);
FindSumm(arr);