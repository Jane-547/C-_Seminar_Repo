// System.Console.WriteLine("Задача 6");
// System.Console.Write("Введите число: ");
// int Number3_1 = Convert.ToInt32(Console.ReadLine());

// if (Number3_1 % 2 == 0)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }


System.Console.WriteLine("Введите число 1");      // Ввести сообщение пользователю (1 число)
string? strSet1_1 = Console.ReadLine();           // Считать строку
int Set1_1 = Convert.ToInt32(strSet1_1);          // Конвертировать текст в число

System.Console.WriteLine("Введите число 2");      // Ввести сообщение пользователю (2 число)
string? strSet1_2 = Console.ReadLine();           // Считать строку
int Set1_2 = Convert.ToInt32(strSet1_2);          // Конвертировать текст в число

System.Console.WriteLine("Введите число 3");      // Ввести сообщение пользователю (3 число)
string? strSet1_3 = Console.ReadLine();           // Считать строку
int Set1_3 = Convert.ToInt32(strSet1_3);          // Конвертировать текст в число

int max = Set1_1;

if (max < Set1_2) max = Set1_2;                  
if (max < Set1_3) max = Set1_3;                  

System.Console.WriteLine("max = " + max);