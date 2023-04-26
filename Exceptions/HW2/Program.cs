// 1. Реализуйте метод, который запрашивает у пользователя ввод дробного числа (типа float), и возвращает введенное значение.
// Ввод текста вместо числа не должно приводить к падению приложения, вместо этого, необходимо повторно запросить у
// пользователя ввод данных.

// float NumberFloat ()
// {
//   float resNum = 0; 
//   System.Console.Write("Введите дробное число: ");
//   while (! float.TryParse(Console.ReadLine(), out resNum))
//   {
//     System.Console.WriteLine("Вы ввели не числовое значение! Введите дробное число: ");
//   }
//   return resNum;
// }

// System.Console.WriteLine($"Вы ввели число {NumberFloat ()}");

// 2. Если необходимо, исправьте данный код:

// try {
//    int d = 0;
//    double catchedRes1 = intArray[8] / d;
//    System.out.println("catchedRes1 = " + catchedRes1);
// } catch (ArithmeticException e) {
//    System.out.println("Catching exception: " + e);
// }

try
{
  int d = 0;

  int [] array = new int [8];
  double catchedRes1 = array / d;
  System.Console.WriteLine($"catchedRes1 = {catchedRes1}");
}
catch (ArithmeticException e)
{
  System.Console.WriteLine("Catching exception: " + e);
}