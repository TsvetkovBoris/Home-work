// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] Array()
{
  double[] arr = new double [size];
  Random rand = new Random();
  for (int i = 0; i < size; i++)
  {
    arr[i] = Math.Round(rand.NextDouble(), 2);
    Console.Write(arr[i] + " ");
  }
  return arr;
}

double Diff(double[] arr, int size)
{
  double max = arr[0];
  double min = arr[0];
  for (int i = 0; i < size; i++)
  {
    if (arr[i] > max)
      max = arr[i];
    else if (arr[i] < min)
      min = arr[i];
  }
  double diff = Math.Round(max - min, 2);
  Console.WriteLine($"\nРазница между максимальным числом {max} и минимальным числом {min} = {diff}");
  return diff;
}
double[] res = Array();
Diff(res, size);