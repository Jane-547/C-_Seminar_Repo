void Program()  // Метод для запуска
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

