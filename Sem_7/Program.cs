Console.Clear();

ProgramHomework7();

void ProgramHomework7()  // Запускатор
{
  while (true)
  {
    System.Console.Write("Введите номер задачи(47, 50, 52, 62 или 000 для выхода): ");

    int task = int.Parse(Console.ReadLine());

    switch (task)
    {
      case 47:
        Console.Clear();
        System.Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
        
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


