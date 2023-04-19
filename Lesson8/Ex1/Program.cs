// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = GetMatrix(rows, columns);
SortMatrix(matrix, rows, columns);

int[,] GetMatrix(int rows, int columns)
{
  int[,] newMatrix = new int[rows, columns];
  Random rand = new Random();
  Console.WriteLine("Обычная матрица");
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      newMatrix[i, j] = rand.Next(20);
      Console.Write(newMatrix[i, j] + " ");
    }
    Console.WriteLine();
  }
  return newMatrix;
}

void SortMatrix(int[,] matrix, int rows, int columns)
{
  Console.WriteLine("Отсортированая матрица");
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns - 1; j++)
    {
      for (int k = 0; k < columns - 1 - j; k++)
      {
        if (matrix[i, j] < matrix[i, k + 1 + j])
        {
          int temp = matrix[i, j];
          matrix[i, j] = matrix[i, k + 1 + j];
          matrix[i, k + 1 + j] = temp;
        }
      }  
    }
  }
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
}