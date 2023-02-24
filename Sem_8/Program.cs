Console.Clear();

ProgramHomework8();

void ProgramHomework8()  // Метод для запуска
{
    while (true)
    {
        System.Console.Write("Введите номер задачи(54, 56, 58, 60 или 000 для выхода): ");

        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 54:
                Console.Clear();
                System.Console.WriteLine("Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
                int matrixRows = NumFromConsole("количество строк");
                int matrixColumns = NumFromConsole("количество столбцов");
                int matrixMinValue = NumFromConsole("минимальное значение числа");
                int matrixMaxValue = NumFromConsole("максимальное значение числа");
                int [,] matrix54 = IntMatrix (matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
                PrintMatrix(matrix54);
                SortRows(matrix54);
                System.Console.WriteLine();
                PrintMatrix(matrix54);
                break;

            case 56:
                Console.Clear();
                System.Console.WriteLine("Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
                matrixRows = NumFromConsole("количество строк");
                matrixColumns = NumFromConsole("количество столбцов");
                matrixMinValue = NumFromConsole("минимальное значение числа");
                matrixMaxValue = NumFromConsole("максимальное значение числа");
                int[,] matrix56 = IntMatrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
                PrintMatrix(matrix56);
                System.Console.WriteLine($"Строка с минимальной суммой элементов находится под {MinRowSum(matrix56)} индексом");
                break;

            case 58:
                Console.Clear();
                System.Console.WriteLine("Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
                System.Console.WriteLine("Первая матрица:");
                matrixRows = NumFromConsole("количество строк");
                matrixColumns = NumFromConsole("количество столбцов");
                matrixMinValue = NumFromConsole("минимальное значение числа");
                matrixMaxValue = NumFromConsole("максимальное значение числа");
                int[,] firstMatrix58 = IntMatrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
                System.Console.WriteLine("Вторая матрица:");
                matrixRows = NumFromConsole("количество строк");
                matrixColumns = NumFromConsole("количество столбцов");
                matrixMinValue = NumFromConsole("минимальное значение числа");
                matrixMaxValue = NumFromConsole("максимальное значение числа");
                int[,] secondMatrix58 = IntMatrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
                PrintMatrix(firstMatrix58);
                System.Console.WriteLine();
                PrintMatrix(secondMatrix58);
                Console.WriteLine();
                if (firstMatrix58.GetLength(1) != secondMatrix58.GetLength(0)) Console.WriteLine("Эти матрицы умножить нельзя!");
                else PrintMatrix(ProductMatrix(firstMatrix58, secondMatrix58));
                break;

            case 60:
                Console.Clear();
                System.Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
                int sizeX = NumFromConsole("размер X");
                int sizeY = NumFromConsole("размер Y");
                int sizeZ = NumFromConsole("размер Z");
                int[,,] matrix60 = CubeMatrix(sizeX, sizeY, sizeZ);
                Print3dMatrix(matrix60);
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

void SortRows (int [,] matrix)  //  Метод для сортировки чисел в строке матрицы
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i,k] < matrix [i,k+1])
                {
                    int temp = matrix [i,k+1];
                    matrix [i,k+1] = matrix[i,k];
                    matrix[i,k] = temp;
                }
            }
            
        }
    }
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

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)  //  Метод для умножения матриц
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int l = 0; l < matrix2.GetLength(0); l++)
            {
                resultMatrix[i, j] += matrix1[i, l] * matrix2[l, j];
            }
        }
    }
    return resultMatrix;
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

int[] Shuffle(int[] arr)  // Метод для перемешивания чисел
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

int[,,] CubeMatrix(int valueX, int valueY, int valueZ)  // Метод для заполнения матрицы неповторяющимися случайными целыми числами от 10 до 99
{
    int[,,] matrix = new int[valueX, valueY, valueZ];

    if ((valueX * valueY * valueZ) > 90) Console.WriteLine("Слишком большой размер. Количество значений не должно превышать 90");
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

void Print3dMatrix(int[,,] matrix)  //  Метод для вывода в консоль 3d матрицы
{
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                System.Console.Write($"{matrix[x, y, z]} ({x}, {y}, {z}) ");
            }
            System.Console.WriteLine();
        }
    }
}