// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

(int rows, int columns, int size) Start()
{
  int size = 20;
  Console.Write("Введите количество строк: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите количество столбцов: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  while (rows == columns)
  {
    Console.WriteLine("Вы ввели не прямоугольную матрицу");
    Console.Write("Введите количество строк: ");
    rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    columns = Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine($"Строка и стоблец = {rows}   {columns}");
  return (rows, columns, size);
}

int[,] GetMatrix(int rows, int columns, int size)
{
  int[,] newMatrix = new int[rows, columns];
  Random rand = new Random();
  Console.WriteLine("Прямоугольная матрица");
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      newMatrix[i, j] = rand.Next(size);
      Console.Write(newMatrix[i, j] + " ");
    }
    Console.WriteLine();
  }
  return newMatrix;
}

void FindMinSumm(int[,] matrix, int rows, int columns, int size)
{ 
  int i = 0;
  int count = 0;  
  int[] summ = new int[size];
  for (i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      summ[i] += matrix[i,j];
    }
    Console.WriteLine($"Сумма элементов {i + 1} строки = " + summ[i]);
  }
  int minSumm = summ[0];
  for (i = 1; i < rows; i++)
  {
    if (minSumm > summ[i])
    {
      minSumm = summ[i];
      count = i;
    }
  }
  Console.WriteLine($"Минимальная сумма элементов в {count + 1} строке равна {minSumm}");
}

var tuple = Start();
int[,] matrix = GetMatrix(tuple.rows, tuple.columns, tuple.size);
FindMinSumm(matrix, tuple.rows, tuple.columns, tuple.size);
