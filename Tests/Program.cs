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

int numRows = NumFromConsole("Rows");
int numColumns = NumFromConsole("Columns");
int numMinValue = NumFromConsole("Min Value");
int numMaxValue = NumFromConsole("Max Value");

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);

int NumFromConsole(string userNumber)
{
    Console.Write($"Введите значение {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}


double [,] DoubleMatrix(int rows, int columns, int min, int max)
{
    double [,] matrix = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}
