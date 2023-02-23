int Exponentiation (int basis, int degree)  //  Метод возведение в степень
{
  int result = 1;
  for (int i = 1; i <= degree; i++)
  {
    result = result * basis;
  }
  return result;
}

int Summa (int Number)  //  Метод сумма цифр в числе
{
  int result = 0;
  for (; Number > 0; Number /= 10)
  {
   result = result + Number%10;
  }
  return result;
}


void Put (int [] Numbers)  //  Метод заполнение одномерного массива рандомом
{
  int length = Numbers.Length;
  
  for (int i = 0; i < length; i++)
  {
      Numbers[i] = new Random().Next(1, 10);
  }
  return;
}

void PutHands (int [] elements)  //  Метод заполнение одномерного массива с клавиатуры
{
  int length = elements.Length;
  
  for (int i = 0; i < length; i++)
  {
      System.Console.WriteLine("Введите элемент: ");
      elements[i] = int.Parse(Console.ReadLine());
  }
  return;
}

void Print (int[] point)  //  Метод вывод в консоль одномерного массива
{
  int digit = point.Length;
  for (int count = 0; count < digit; count++)
  {
      System.Console.Write(point[count] + " ");
  }
  return;
}

void Program()  // Метод для запуска домашек - свитч
{
    while (true)
    {
        System.Console.Write("Введите номер задачи(34, 36, 38 или 000 для выхода): ");

        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 34:
                Console.Clear();
                System.Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
                int[] Array34 = RandomArray(8, 100, 999);
                System.Console.WriteLine(String.Join(" ", Array34));
                System.Console.WriteLine($"Количество четных элементов в массиве - {CountPositiveNumbers(Array34)}");
                break;

            case 36:
                Console.Clear();
                System.Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
                int[] Array36 = RandomArray(6, 0, 10);
                System.Console.WriteLine(String.Join(" ", Array36));
                System.Console.WriteLine($"Сумма элементов, находящихся на нечетных позициях в массиве - {SumOfNegatives(Array36)}");
                break;

            case 38:
                Console.Clear();
                System.Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
                double[] Array38 = RandomDoubleArray(6, 0, 10);
                System.Console.WriteLine(String.Join(" ", Array38));
                System.Console.WriteLine($"Разница между максимальным и минимальным значением - {MinMax(Array38)}");
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

int[] RandomArray(int size, int minValue, int maxValue)  // Метод для заполнения массива случайными числами
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int CountPositiveNumbers(int[] Array)  // Метод для подсчета количества положительных элементов
{
    int count = 0;
    foreach (var value in Array)
    {
        value % 2 == 0 ? count++ : 0;
    }
    return count;
}

int SumOfNegatives(int[] Array)  // Метод для подсчета элементов с нечетными индексами
{
    int sum = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        if (i % 2 != 0) sum += Array[i];
    }
    return sum;
}

double[] RandomDoubleArray(int size, int minValue, int maxValue)  // Метод для заполнения массива случайными вещественными числами
{
    double[] res = new double[size];
    var rand = new Random();

    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToDouble(rand.Next(-100, 100)/10.0);
    }
    return res;
}

double MinMax(double[] Array)  // Метод для нахождения разницы между максимальным и минимальным значениями в массиве

{
    double Min = Array[0];
    double Max = Array[0];

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < Min) Min = Array[i];
        if (Array[i] > Max) Max = Array[i];
    }
    return Max - Min;
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
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Решений нет!");

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