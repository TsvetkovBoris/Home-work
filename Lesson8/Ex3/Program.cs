// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

(int rowsOne, int columnsOne, int rowsTwo, int columnsTwo) Start()
{
  Console.Write("Введите количество строк для 1ой матрицы: ");
  int rowsOne = int.Parse(Console.ReadLine());
  Console.Write("Введите количество столбцов для 1ой матрицы: ");
  int columnsOne = int.Parse(Console.ReadLine());

  Console.Write("Введите количество строк для 2ой матрицы: ");
  int rowsTwo = int.Parse(Console.ReadLine());
  Console.Write("Введите количество столбцов для 2ой матрицы: ");
  int columnsTwo = int.Parse(Console.ReadLine());

  while (columnsOne != rowsTwo)
  {
    Console.WriteLine("Умножение таких матриц невозможно, количество столбцов 1ой матрицы должно равняться количеству строк 2ой");
    Console.Write("Введите количество строк для 1ой матрицы: ");
    rowsOne = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов для 1ой матрицы: ");
    columnsOne = int.Parse(Console.ReadLine());

    Console.Write("Введите количество строк для 2ой матрицы: ");
    rowsTwo = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов для 2ой матрицы: ");
    columnsTwo = int.Parse(Console.ReadLine());
  }

  return (rowsOne, columnsOne, rowsTwo, columnsTwo);
}

int[,] GetMatrixOne(int rows, int columns)
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

int[,] MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo, int rowsOne, int columnsOne, int rowsTwo, int columnsTwo)
{
  int i = 0;
  int j = 0;
  int k = 0;
  int[,] matrixMultiply = new int[rowsOne, columnsTwo];
  Console.WriteLine("Произведение двух матриц");
  for (i = 0; i < rowsOne; i++)
  {
    for (j = 0; j < columnsTwo; j++)
    {
      int Multiply = 0;
      for (k = 0; k < rowsTwo; k++)
        Multiply += matrixOne[i, k] * matrixTwo[k, j];
      matrixMultiply[i, j] = Multiply;
    }
  }
  for (i = 0; i < rowsOne; i++)
  {
    for (j = 0; j < columnsTwo; j++)
    {
      Console.Write(matrixMultiply[i, j] + " ");
    }
  Console.WriteLine();  
  }
  return matrixMultiply;
}

var tuple = Start();
Console.WriteLine("Первая матрица");
int[,] matrixOne = GetMatrixOne(tuple.rowsOne, tuple.columnsOne);
Console.WriteLine("Вторая матрица");
int[,] matrixTwo = GetMatrixOne(tuple.rowsTwo, tuple.columnsTwo);
int[,] matrixMulti = MultiplyMatrix(matrixOne, matrixTwo, tuple.rowsOne, tuple.columnsOne, tuple.rowsTwo, tuple.columnsTwo);