/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

System.Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine());
int invert = 0;
int temp = Number;

while (temp > 0)
{
  int intermediate = temp % 10;
  temp = temp / 10;
  invert = invert * 10 + intermediate;
}

if (Number == invert) System.Console.WriteLine("Число является палиндромом");
else System.Console.WriteLine("Число не является палиндромом");

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

System.Console.WriteLine("-------Задача № 21-------");
System.Console.WriteLine("Введите координаты точки A");
System.Console.WriteLine("Координата x");
double coordxA = double.Parse(Console.ReadLine());

System.Console.WriteLine("Координата y");
double coordyA = double.Parse(Console.ReadLine());

System.Console.WriteLine("Координата z");
double coordzA = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B");
System.Console.WriteLine("Координата x");
double coordxB = double.Parse(Console.ReadLine());

System.Console.WriteLine("Координата y");
double coordyB = double.Parse(Console.ReadLine());

System.Console.WriteLine("Координата z");
double coordzB = double.Parse(Console.ReadLine());

System.Console.WriteLine($"Расстояние между точками = {Math.Sqrt(Math.Pow((coordxB-coordxA), 2)+Math.Pow((coordyB-coordyA), 2)+Math.Pow((coordzB-coordzA), 2))}");

/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

System.Console.WriteLine("-------Задача № 23-------");
System.Console.Write("Введите число: ");
int NumberN = int.Parse(Console.ReadLine());

double Cube=1;

while (Cube<=NumberN)
{
    System.Console.Write(Math.Pow(Cube,3)+" ");
    Cube++;
}