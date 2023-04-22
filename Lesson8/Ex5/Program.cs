// Напишите программу, которая заполнит спирально массив. Размер вводит юзер.
Console.Write("Введите количество элементов в строке: "); 
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите количество элементов в cтолбце: "); 
int columns = Convert.ToInt32(Console.ReadLine()); 

int[,] GetMatrix(int rows, int columns)
{
  int[,] matrix = new int[rows, columns]; 
  int count = 1; 
  int temp = 0; 
  int i, j = 0;
  int size = rows * columns;
  while (count <= size) 
  { 
    for (i = temp; i < columns; i++) 
      matrix[j, i] = count++; 
    j = columns - 1;
    for (i = temp + 1; i < rows; i++) 
      matrix[i, j] = count++; 
    j = rows - 1; 
    for (i = columns - 2; i >= temp; i--) 
      matrix[j, i] = count++; 
    j = temp; 
    for (i = rows - 2; i > temp; i--) 
      matrix[i, j] = count++; 
    columns--; 
    rows--; 
    temp++; 
    j = temp; 
  } 
  for (i = 0; i < matrix.GetLength(0); i++) 
  { 
    for (j = 0; j < matrix.GetLength(1); j++) 
      Console.Write("{0, 3} ", matrix[i, j]); 
    Console.WriteLine(); 
  }
  return matrix;
}

int[,] newArray = GetMatrix(rows, columns);

