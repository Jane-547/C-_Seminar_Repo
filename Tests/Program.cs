﻿// System.Console.WriteLine("Задание 15");

// System.Console.WriteLine("Введите число обозначающее день недели от 1 до 7 ");

// int number = int.Parse(Console.ReadLine());

// if (number>5)
// {
//     System.Console.WriteLine("Да");
// }
// else if(number<=5)
// {
//    System.Console.WriteLine("Нет");
// }
// else
// {
//     System.Console.WriteLine("Это число не в диапазоне от 1 до 7");
// }

// System.Console.Write("Введите число: ");
// string? strNum1 = Console.ReadLine();
// int Num1 = Convert.ToInt32(strNum1);

// if (Num1 < 100 || Num1 > 999)
//     System.Console.WriteLine("Неверное число");
// else
// {
//     int res = (Num1 / 10) % 10;
//     System.Console.WriteLine(res);
// }

// int[] Array = new int[8];

// void PutHands (int [] elements)
// {
//   int length = elements.Length;
  
//   for (int i = 0; i < length; i++)
//   {
//       System.Console.WriteLine("Введите элемент: ");
//       elements[i] = int.Parse(Console.ReadLine());
//   }
//   return;
// }

// void Print (int[] point)
// {
//   int digit = point.Length;
//   for (int count = 0; count < digit; count++)
//   {
//       System.Console.Write(point[count] + " ");
//   }
//   return;
// }

// PutHands(Array);
// Print (Array);

int[] GetAB(int num1, int num2)
{
    int[] Array = new int[2];
    Console.WriteLine("Enter the 1st number: ");
    Array[0] = int.Parse(Console.ReadLine());
    Console.Write("Enter the 2d number: ");
    Array[1] = int.Parse(Console.ReadLine());
    return Array;
    Console.Write($"Entered numbers {Array[0]}, {Array[1]}");
}