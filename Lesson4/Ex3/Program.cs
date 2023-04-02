// Задача 23  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

  while (Math.Abs(N) >= i)
  { 
    Console.Write($"{Math.Pow(i, 3)}  ");  
    i += 1;
  }