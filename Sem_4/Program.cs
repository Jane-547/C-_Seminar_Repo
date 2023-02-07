/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

System.Console.WriteLine("-------Задача № 25-------");
System.Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());

System.Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

int Exponentiation (int basis, int degree)
{
  int result = 1;
  for (int i = 1; i <= degree; i++)
  {
    result = result * basis;
  }
  return result;
}

System.Console.WriteLine($"A в степени B равно: {Exponentiation(numA, numB)}");

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

System.Console.WriteLine("-------Задача № 27-------");
System.Console.Write("Введите число: ");
int mean = int.Parse(Console.ReadLine());
int Summa (int Number)
{
  int result = 0;
  for (; Number > 0; Number /= 10)
  {
   result = result + Number%10;
  }
  return result;
}

System.Console.WriteLine($"Сумма цифр в числе равна {Summa(mean)}");

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

System.Console.WriteLine("-------Задача № 29-------");
int[] Array = new int[8];

void Put (int [] Numbers)
{
  int length = Numbers.Length;
  
  for (int i = 0; i < length; i++)
  {
      Numbers[i] = new Random().Next(1, 10);
  }
  return;
}

void PutHands (int [] elements)
{
  int length = elements.Length;
  
  for (int i = 0; i < length; i++)
  {
      System.Console.WriteLine("Введите элемент: ");
      elements[i] = int.Parse(Console.ReadLine());
  }
  return;
}

void Print (int[] point)
{
  int digit = point.Length;
  for (int count = 0; count < digit; count++)
  {
      System.Console.Write(point[count] + " ");
  }
  return;
}

Put(Array);
Print(Array);

System.Console.WriteLine();
System.Console.WriteLine("--------------Вариант с ручным вводом элементов--------------");

PutHands(Array);
Print(Array);
