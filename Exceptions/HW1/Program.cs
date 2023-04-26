// Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый
// массив, каждый элемент которого равен разности элементов двух входящих массивов в той же ячейке.
// Если длины массивов не равны, необходимо как-то оповестить пользователя.

int NumFromConsole(string userNumber)  //  Метод для ввода значений с консоли
{
    Console.Write($"Введите значение {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
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

void Print (int[] point)  //  Метод вывод в консоль одномерного массива
{
  int digit = point.Length;
  for (int count = 0; count < digit; count++)
  {
      System.Console.Write(point[count] + " ");
  }
  return;
}

int[] Difference (int[] arr1, int[] arr2) // Метод подсчета разницы значений массива
{
    int[] ResArray = new int[arr1.Length];
    if (arr1.Length != arr2.Length)
    {
        System.Console.WriteLine("Длины массивов различны!");
    }
    else
    {
        for (int i = 0; i < arr1.Length; i++)
        {
            ResArray[i] = arr1[i] - arr2[i];
        }
        Print(ResArray);
    }
    return ResArray;
}

int numValue1 = NumFromConsole("size 1");
int numMinValue1 = NumFromConsole("min value");
int numMaxValue1 = NumFromConsole("max value");
int[] Array1 = RandomArray(numValue1, numMinValue1, numMaxValue1);
Print(Array1);
System.Console.WriteLine();

int numValue2 = NumFromConsole("size 2");
int numMinValue2 = NumFromConsole("min value");
int numMaxValue2 = NumFromConsole("max value");
int[] Array2 = RandomArray(numValue2, numMinValue2, numMaxValue2);
Print(Array2);
System.Console.WriteLine();

Difference (Array1, Array2);

// Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий
// новый массив, каждый элемент которого равен частному элементов двух входящих массивов в той же
// ячейке. Если длины массивов не равны, необходимо как-то оповестить пользователя. Важно: При выполнении
// метода единственное исключение, которое пользователь может увидеть - RuntimeException, т.е. ваше.

int[] DifferenceElse(int[] arr1, int[] arr2) // Метод подсчета разницы значений массива, второй вариант
{
    int[] ResArray = new int[arr1.Length];
    try
    {
        if (arr1.Length != arr2.Length)
        {
            throw new Exception("Длины массивов различны!");
        }
        else
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                ResArray[i] = arr1[i] - arr2[i];
            }
            Print(ResArray);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ошибка: {e.Message}");
    }
    return ResArray;
}

// Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий
// новый массив, каждый элемент которого равен сумме элементов двух входящих массивов в той же ячейке.
// Если длины массивов не равны, необходимо как-то оповестить пользователя.

int[] SumTwoArrays(int[] arr1, int[] arr2) // То же самое, только один знак меняется
{
    int[] ResArray = new int[arr1.Length];
    try
    {
        if (arr1.Length != arr2.Length)
        {
            throw new Exception("Длины массивов различны!");
        }
        else
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                ResArray[i] = arr1[i] + arr2[i];
            }
            Print(ResArray);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ошибка: {e.Message}");
    }
    return ResArray;
}

// Реализуйте метод, принимающий в качестве аргументов двумерный массив. Метод должен проверить
// что длина строк и столбцов с одинаковым индексом одинакова, детализировать какие строки со
// столбцами не требуется. Как бы вы реализовали подобный метод?

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

void MatrixCube(int[,] matrix)  // Метод для сравнения столбцов и строк
{
    try
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            throw new Exception("Длина строк и столбцов не одинакова!");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ошибка: {e.Message}");
    }
    finally
    {
        PrintMatrix(matrix); // Все равно хотим вывести матрицу в консоль, это чтобы попробовать finally)))
    }
}

int[,] MyMatrix = IntMatrix(5, 6, 1, 9);
MatrixCube(MyMatrix);
