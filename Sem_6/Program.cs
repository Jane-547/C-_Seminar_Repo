/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

//   System.Console.WriteLine("Введите 5 целых чисел через пробел:");
//   string values = Console.ReadLine();
    
//   string[] stringValues = values.Split(' ');



// int ArrayFromString (string [] array)
// {
//   int [] outValues = new int [5];

//   for (int i = 0; i < array.Length; i++)
//   {
//       outValues [i] = int.Parse(array [i]);
//   }
//   return outValues;
// }

// int CountPositiveNumbers(int[] array)  // Метод для подсчета количества положительных элементов
// {
//     int count = 0;
//     foreach (var i in array)
//     {
//         i > 0 ? count++ : 0;
//     }
//     return count;
// }

// ArrayFromString(stringValues);
// CountPositiveNumbers(ArrayFromString);

// System.Console.WriteLine($"Пользователь ввел {CountPositiveNumbers} чисел больше 0");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Задача 44:выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// int Fibonacci (int n)
// {
//   if (n == 1 || n == 2) return 1;
//   else 
//   {
//     return Fibonacci (n-1) + Fibonacci (n-2);
//   }
// }

// System.Console.WriteLine("Введите число n:");
// int n = (int.Parse(Console.ReadLine()));
// System.Console.WriteLine("0");

// Fibonacci (n);

// for (int i = 1; i < n; i++)
//   {
//     System.Console.WriteLine(Fibonacci(i));
//   }