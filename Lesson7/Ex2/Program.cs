// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
GetMatrix(rows, columns);
FindNumber(matrix, rows, columns);

int[,] GetMatrix(int rows, int columns)
{
  Random rand = new Random();
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = rand.Next(100);
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
  return matrix;
}

int FindNumber(int[,] matrix, int rows, int columns)
{
  Console.Write("Введите любое целое число: ");
  int number = Convert.ToInt32(Console.ReadLine());
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      if (number == matrix[i, j])
      {
        Console.Write($"Номер строки: {i + 1} Номер столбца: {j + 1}");
        return number;
      }
    }
  }
  Console.WriteLine("Такого числа в массиве нет");
  return number;
}

