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
                System.Console.WriteLine("Задача 47. Задайте двумерный массив размером m * n, заполненный случайными вещественными числами.");
                int numRows = NumFromConsole("Rows");
                int numColumns = NumFromConsole("Columns");
                var matrix47 = DoubleMatrix(numRows, numColumns);
                PrintDoubleMatrix(matrix47);
                break;

            case 50:
                Console.Clear();
                System.Console.Write("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,");
                System.Console.WriteLine(" и возвращает значение этого элемента или же указание, что такого элемента нет.");
                numRows = NumFromConsole("Rows");
                numColumns = NumFromConsole("Columns");
                int numMinValue = NumFromConsole("Min Value");
                int numMaxValue = NumFromConsole("Max Value");
                int[,] matrix50 = IntMatrix(numRows, numColumns, numMinValue, numMaxValue);
                PrintMatrix(matrix50);
                IndexValue(matrix50);
                break;

            case 52:
                Console.Clear();
                System.Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
                numRows = NumFromConsole("Rows");
                numColumns = NumFromConsole("Columns");
                numMinValue = NumFromConsole("Min Value");
                numMaxValue = NumFromConsole("Max Value");
                int[,] matrix52 = IntMatrix(numRows, numColumns, numMinValue, numMaxValue);
                PrintMatrix(matrix52);
                System.Console.WriteLine($"Среднее арифметическое: ");
                ColumnsAverage(matrix52);
                break;

            case 62:
                Console.Clear();
                System.Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
                int size = NumFromConsole("размер матрицы");
                int[,] matrix62 = new int[size, size];
                SpiralFilling(matrix62);
                PrintMatrix(matrix62);
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


double[,] DoubleMatrix(int rows, int columns) // Метод для заполнения матрицы случайными вещественными числами
{
    double[,] matrix = new double[rows, columns];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Convert.ToDouble(rand.Next(-100, 100) / 10.0);
        }
    }
    return matrix;
}

void PrintDoubleMatrix(double[,] matrix)  // Метод для вывода матрицы double в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
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


void IndexValue(int[,] matrix)  // Метод для вывода значения по индексу элемента
{
    int userI = NumFromConsole("индекс строки");
    int userJ = NumFromConsole("индекс столбца");

    if (userI > matrix.GetLength(0) || userJ > matrix.GetLength(1))
        System.Console.WriteLine("Такого элемента нет!");
    else
    {
        System.Console.WriteLine($"На этой позиции находится число {matrix[userI, userJ]}");
    }
}

void ColumnsAverage(int[,] matrix)  //  Метод для вычисления среднего арифметического по столбцам
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        average = sum / matrix.GetLength(0);
        System.Console.WriteLine($"столбец {j}: {Math.Round(average, 2)}");
    }
}

int[,] SpiralFilling(int[,] matrix)  //  Метод для заполнения матрицы по спирали
{
    int value = 1;
    int size = matrix.GetLength(0);
    int maxIndex = size - 1;
    int i = 0;
    int j = 0;

    while (value <= size * size)
    {
        matrix[i, j] = value;
        value++;
        if (i <= j + 1 && i + j < maxIndex)
            j++;
        else if (i < j && i + j >= maxIndex)
            i++;
        else if (i >= j && i + j > maxIndex)
            j--;
        else
            i--;
    }
    return matrix;
}