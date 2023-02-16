Console.Clear();

ProgramHomework6();

void ProgramHomework6()  // Запускатор
{
  while (true)
  {
    System.Console.Write("Введите номер задачи(41, 43, 44 или 000 для выхода): ");

    int task = int.Parse(Console.ReadLine());

    switch (task)
    {
      case 41:
        Console.Clear();
        System.Console.WriteLine("Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        System.Console.WriteLine("Введите целые числа через пробел:");
        int[] outValues = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        System.Console.WriteLine($"Пользователь ввел {CountPositiveNumbers(outValues)} чисел больше 0");
        break;

      case 43:
        Console.Clear();
        System.Console.Write("Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, ");
        System.Console.WriteLine("заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        Task43();
        break;

      case 44:
        Console.Clear();
        System.Console.WriteLine("Задача 44:выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.");
        System.Console.WriteLine("Введите число n:");
        PrintFibonacci(int.Parse(Console.ReadLine()));
        break;

      case 000:
        return;
        break;

      default:
        Console.Clear();
        System.Console.WriteLine("Неверное значение");
        break;
    }
  }
}

int CountPositiveNumbers(int[] array)  // Метод для подсчета количества положительных элементов
{
  int count = 0;
  foreach (var i in array)
  {
    if (i > 0)
      count++;
  }
  return count;
}

void Task43()  // Метод для решения задачи № 43
{
  System.Console.Write("Задайте значение b1: ");
  double b1 = int.Parse(Console.ReadLine());

  System.Console.Write("Задайте значение b2: ");
  double b2 = int.Parse(Console.ReadLine());

  System.Console.Write("Задайте значение k1: ");
  double k1 = int.Parse(Console.ReadLine());

  System.Console.Write("Задайте значение k2: ");
  double k2 = int.Parse(Console.ReadLine());

  double x = (b2 - b1) / (k1 - k2);
  double y = k2 * x + b2;

  if ((y != k1 * x + b1) || (k1 - k2 == 0)) System.Console.WriteLine("Решений нет!");
  else
  {
    System.Console.WriteLine($"Координаты пересечения двух прямых, x, y: ({x}); ({y})");
  }
}

int Fibonacci (int n)  // Метод для вычисления числа Фибоначчи
{
return n > 1 ? Fibonacci(n - 1) + Fibonacci(n - 2) : n;
}

int PrintFibonacci (int n)  //  Вывод последовательности Фибоначчи
{

  for (int i = 0; i < n; i++)
  {
    System.Console.WriteLine(Fibonacci(i));
  }
  return Fibonacci(n);
}
