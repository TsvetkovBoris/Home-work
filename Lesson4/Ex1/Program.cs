// Задача 19  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятичзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
int num_save = num;

while (num > 0)
{
  num = num / 10;
  i++;
}
if (i != 5)
  Console.WriteLine("Вы ввели не пятизначное число");
else
{
int num_r = num_save % 100;
int num_l = num_save / 1000;
int num_1 = num_r / 10;
int num_2 = num_r % 10;
string result = Convert.ToString($"{num_2}{num_1}");
int number = Convert.ToInt32(result);
if (number == num_l)
  Console.WriteLine($"Число {num_save} является палиндромом");
else
  Console.WriteLine($"Число {num_save} не является палиндромом");
}