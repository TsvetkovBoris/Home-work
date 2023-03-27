System.Console.Write("Введите первое число = ");
int num1 = Convert.ToInt32(Console.ReadLine());;
System.Console.Write("Введите первое число = ");
int num2 = Convert.ToInt32(Console.ReadLine());;
if (num1 > num2)
  {
  Console.WriteLine("Максимальное число = " + num1);
  Console.WriteLine("Минимальное число = " + num2);
  }
else 
  {
  Console.WriteLine("Максимальное число число = " + num2);
  Console.WriteLine("Минимальное число = " + num1);
  }