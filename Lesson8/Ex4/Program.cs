// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] GetMatrixThree(int x, int y, int z)
{
  int count = 0;
  int[,,] MatrixThree = new int[x, y, z];
  Random rand = new Random();
  int size = x * y * z;
  int[] UniqueNumber = new int[size];
  for (int i = 0; i < size; i++)
  {
    UniqueNumber[i] = rand.Next(10, 100);
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (UniqueNumber[i] == UniqueNumber[j])
        {
          UniqueNumber[i] = rand.Next(10, 100);
          j = 0;
        }
      }
    }
  }
  
  Console.WriteLine("Трехмерная матрица");
  for (int i = 0; i < x; i++)
  {
    for (int j = 0; j < y; j++)
    {
      for (int k = 0; k < z; k++)
      {
        MatrixThree[i, j, k] = UniqueNumber[count];
        count++;
        Console.Write($"{MatrixThree[i, j, k]} {(i,j,k)} ");
      }
      Console.WriteLine();
    }
  }
  return MatrixThree;
}

GetMatrixThree(x, y, z);