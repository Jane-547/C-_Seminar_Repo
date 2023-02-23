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

// int n = 4;
// int[,] spiralMatrix = new int[n, n];

// int temp = 1;
// int c = 0;
// int d = 0;

// while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
// {
//   spiralMatrix[c, d] = temp;
//   temp++;
//   if (c <= d + 1 && c + d < spiralMatrix.GetLength(1) - 1)
//     d++;
//   else if (c < d && c + d >= spiralMatrix.GetLength(0) - 1)
//     c++;
//   else if (c >= d && c + d > spiralMatrix.GetLength(1) - 1)
//     d--;
//   else
//     c--;
// }

// PrintMatrix(spiralMatrix);

// int size = NumFromConsole("размер матрицы");
// int [,] matrix62 = new int [size,size];
// SpiralFilling (matrix62);
// PrintMatrix(matrix62);



// int [,] SpiralFilling (int [,] matrix)
// {
//     int value = 1;
//     int maxIndex = size - 1;
//     int i = 0;
//     int j = 0;

//   while (value <= size * size)
//   {
//     matrix [i,j] = value;
//     value++;
//     if (i <= j + 1 && i + j < maxIndex)
//         j++;
//     else if (i < j && i + j >= maxIndex)
//         i++;
//     else if (i >= j && i + j > maxIndex)
//         j--;
//     else
//         i--;   
//   }
//   return matrix;
// }



// Задача 54: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int sizeX = NumFromConsole("размер X");
int sizeY = NumFromConsole("размер Y");
int sizeZ = NumFromConsole("размер Z");

int [,,] matrix60 = CubeMatrix (sizeX, sizeY, sizeZ);

Print3dMatrix(matrix60);
Console.ReadKey();



int[,,] CubeMatrix (int valueX, int valueY, int valueZ)  // Метод для заполнения матрицы неповторяющимися случайными целыми числами от 10 до 99
{
    int[,,] matrix = new int[valueX, valueY, valueZ];

    if ((valueX * valueY * valueZ) > 99) Console.WriteLine("Слишком большой размер. Количество значений не должно превышать 99");
    int[] array = new int[90];
    PutOrder(array);
    Shuffle(array);

    for (int i = 0; i < valueX * valueY * valueZ;)
    {
        for (int x = 0; x < valueX; x++)
        {
            for (int y = 0; y < valueY; y++)
            {
                for (int z = 0; z < valueZ; z++)
                {                              
                    matrix[x, y, z] = array[i];
                    i++;
                }
            
            }
        }
    }
return matrix;
}

void PutOrder(int[] Numbers)  //  Метод заполнение одномерного массива по порядку
{
    int length = Numbers.Length;

    for (int i = 0; i < length; i++)
    {
        Numbers[i] = i + 10;
    }
    return;
}

int [] Shuffle(int[] arr)  // Метод для перемешивания чисел
{
    Random rand = new Random();

    for (int i = arr.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);

        int temp = arr[j];
        arr[j] = arr[i];
        arr[i] = temp;
    }
    return arr;
}

void Print3dMatrix (int[,,] matrix)  //  Метод для вывода в консоль 3d матрицы
{
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0;z < matrix.GetLength(2); z++)
            {
                System.Console.Write($"{matrix[x, y, z]} ({x}, {y}, {z}) ");
            }
            System.Console.WriteLine();
        }
    }
}

int [,] ProductMatrix (int[,] matrix1, int [,] matrix2)  //  Метод для умножения матриц
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Решений нет!");
    
    int [,] resultMatrix = new int [matrix1.GetLength(0),matrix2.GetLength(1)];
   
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0;  j < matrix2.GetLength(1); j++)
        {
            for (int l = 0; l < matrix2.GetLength(0); l++)
            {
                resultMatrix[i, j] += matrix1[i, l] * matrix2[l, j];
            }
        }
    }
    return resultMatrix;      
}


int MinRowSum(int[,] matrix)  //  Метод для нахождения строки с минимальной суммой элементов
{
    int row = 0;
    int? min = null;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (min == null) min = sum;
        else if (sum < min)
        {
            min = sum;
            row = i;
        }
        System.Console.WriteLine($"Сумма элементов {i} строки равна {sum}");
    }
    return row;
}



void SortRows(int[,] matrix)  //  Метод для сортировки чисел в строке матрицы
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }

        }
    }
}

int NumFromConsole(string userNumber)  //  Метод для ввода значений с консоли
{
    Console.Write($"Введите значение {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] IntMatrix(int rows, int columns, int min, int max)  // Метод для заполнения матрицы случайными целыми числами
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)  // Метод для вывода матрицы int
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0 && matrix[i, j] < 10)
                System.Console.Write("0" + matrix[i, j] + " ");
            else
                System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}