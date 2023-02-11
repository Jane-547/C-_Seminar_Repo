Console.Clear();

Program();

void Program()  // Надеюсь получится)))
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
        if (value % 2 == 0) count++;
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
        res[i] = Math.Round((rand.Next(minValue, maxValue + 1) + rand.NextDouble()), 2);
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
