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

// System.Console.WriteLine("Начинаем");

// int d = 0;

// int [] array = new int [9];

// try
// {
//   double catchedRes1 = array[8] / d;
//   System.Console.WriteLine($"catchedRes1 = {catchedRes1}");
// }
// catch (ArithmeticException e)
// {
//   System.Console.WriteLine("Catching exception: " + e);
// }
// System.Console.WriteLine("Конец");

// Дан следующий код, исправьте его там, где требуется

// public static void main(String[] args) throws Exception {
//    try {
//        int a = 90;
//        int b = 3;
//        System.out.println(a / b);
//        printSum(23, 234);
//        int[] abc = { 1, 2 };
//        abc[3] = 9;
//    } catch (Throwable ex) {
//        System.out.println("Что-то пошло не так...");
//    } catch (NullPointerException ex) {
//        System.out.println("Указатель не может указывать на null!");
//    } catch (IndexOutOfBoundsException ex) {
//        System.out.println("Массив выходит за пределы своего размера!");
//    }
// }
// public static void printSum(Integer a, Integer b) throws FileNotFoundException {
//    System.out.println(a + b);
// }

public static void main(String[] args) throws Exception {
   try {
       int a = 90;
       int b = 3;
       System.out.println(a / b);
       printSum(23, 234);
       int[] abc = { 1, 2 };
       abc[3] = 9;
   } catch (Throwable ex) {
       System.out.println("Что-то пошло не так...");
   } catch (NullPointerException ex) {
       System.out.println("Указатель не может указывать на null!");
   } catch (IndexOutOfBoundsException ex) {
       System.out.println("Массив выходит за пределы своего размера!");
   }
}
public static void printSum(Integer a, Integer b) throws FileNotFoundException {
   System.out.println(a + b);
}