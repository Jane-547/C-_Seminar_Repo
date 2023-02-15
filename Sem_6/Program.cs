/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

System.Console.WriteLine("Введите 5 целых чисел через пробел:");
  string values = Console.ReadLine();
    
  string[] stringValues = values.Split(' ');



int ArrayFromString (string [] array)
{
  int [] outValues = new int [5];

  for (int i = 0; i < array.Length; i++)
  {
      outValues [i] = int.Parse(array [i]);
  }
  return outValues;
}

int CountPositiveNumbers(int[] array)  // Метод для подсчета количества положительных элементов
{
    int count = 0;
    foreach (var i in array)
    {
        i > 0 ? count++ : 0;
    }
    return count;
}

ArrayFromString(stringValues);
CountPositiveNumbers(ArrayFromString);

System.Console.WriteLine($"Пользователь ввел {CountPositiveNumbers} чисел больше 0");