Console.Clear();

ProgramHomework9();

void ProgramHomework9()  // Метод для запуска
{
    while (true)
    {
        System.Console.Write("Введите номер задачи(64, 66, 68 или 000 для выхода): ");

        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 64:
                Console.Clear();
                System.Console.WriteLine("Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
                int numberN = NumFromConsole("число N");
               
                break;

            case 56:
                Console.Clear();
                System.Console.WriteLine("Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
                
                break;

            case 58:
                Console.Clear();
                System.Console.WriteLine("Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
                
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

