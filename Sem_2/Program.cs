/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

// System.Console.WriteLine("-------Задача № 10-------");
// System.Console.Write("Введите трехзначное число: ");
// int numXXX;
// if (! int.TryParse(Console.ReadLine(), out numXXX))
// {
//   System.Console.WriteLine("Вы ввели не число!");
//   return;
// }

// int res = (numXXX / 10) % 10;

// if (numXXX / 100 < 1 || numXXX / 100 > 10)
//   System.Console.WriteLine("Вы ввели не трехзначное число!");
// else
//   System.Console.WriteLine($"Ответ: {res}");

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("-------Задача № 13-------");
System.Console.Write("Введите число: ");
int Value;
if (! int.TryParse(Console.ReadLine(), out Value))
{
  System.Console.WriteLine("Вы ввели не числовое значение!");
  return;
}

int ValueAbs = Math.Abs(Value);
if (ValueAbs < 100)
{
  System.Console.WriteLine("Третьей цифры нет.");
  return;
}

while (ValueAbs < 999)
{
 ValueAbs = ValueAbs / 10;
}

System.Console.WriteLine($"Третья цифра в числе - {ValueAbs%10}");

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

// System.Console.WriteLine("-------Задача № 15-------");
// System.Console.WriteLine("Вариант красивый");
// System.Console.Write("Какой по счету день недели? ");
// int DayOfWeek;
// if (! int.TryParse(Console.ReadLine(), out DayOfWeek))
// {
//   System.Console.WriteLine("Вы ввели не числовое значение!");
//   return;
// }

// switch (DayOfWeek)
// {
//     case 1:
//     System.Console.WriteLine("Сегодня понедельник, рабочий день(((");
//     break;
//     case 2:
//     System.Console.WriteLine("Сегодня вторник, рабочий день(((");
//     break;
//     case 3:
//     System.Console.WriteLine("Сегодня среда, рабочий день(((");
//     break;
//     case 4:
//     System.Console.WriteLine("Сегодня четверг, рабочий день(((");
//     break;
//     case 5:
//     System.Console.WriteLine("Сегодня пятница, рабочий день(((");
//     break;
//     case 6:
//     System.Console.WriteLine("Сегодня суббота, ВЫХОДНОЙ!!!");
//     break;
//     case 7:
//     System.Console.WriteLine("Сегодня воскресенье, ВЫХОДНОЙ!!!");
//     break;
//     default:
//     System.Console.WriteLine("Нет такого дня недели!");
//     break;
// }

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

// System.Console.WriteLine("-------Задача № 15-------");
// System.Console.WriteLine("Вариант более короткий, оптимизированный");
// System.Console.Write("Какой по счету день недели? ");

// int DayOfWeek1;
// if (! int.TryParse(Console.ReadLine(), out DayOfWeek1))
// {
//   System.Console.WriteLine("Вы ввели не числовое значение!");
//   return;
// }

// if (DayOfWeek1 < 0 || DayOfWeek1 > 7)
// {
//   System.Console.WriteLine("Нет такого дня недели!");
//   return;
// }

// if (DayOfWeek1 == 6 || DayOfWeek1 == 7)
// System.Console.WriteLine("Ура, сегодня выходной!");
// else
// System.Console.WriteLine("Сегодня рабочий день(((");
