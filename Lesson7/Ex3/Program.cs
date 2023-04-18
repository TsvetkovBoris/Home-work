// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] newArray = GetMatrix(rows, columns);
FindAverage(newArray, rows, columns);

int[,] GetMatrix(int rows, int columns)
{
  int[,] matrix = new int[rows, columns];
  Random rand = new Random();
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = rand.Next(10);
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
  return matrix;
}

double FindAverage(int[,] matrix, int rows, int columns)
{
  double average = 0;
  for (int j = 0; j < columns; j++)
  {
    average = 0;
    for (int i = 0; i < rows; i++)
      average += matrix[i, j];
    average /= rows;
    Console.Write($"Среднее арифмитическое в {j + 1} столбце = " + Math.Round(average, 2) + "\n");
  }
  return average;
}