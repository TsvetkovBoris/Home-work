// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetArray()
{
  Random rand = new Random();
  Console.Write("Введите количество строк: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите количество столбцов: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  double[,] matrix = new double[rows, columns];
  for (int i = 0; i < rows; i++)
  {
      for (int j = 0; j < columns; j++)
      {
        matrix[i, j] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
        Console.Write(matrix[i, j] + " ");
      }
      Console.WriteLine();
  }
  return matrix;
}
GetArray();