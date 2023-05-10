// 1. Реализуйте метод, который запрашивает у пользователя ввод дробного числа (типа float), и возвращает введенное значение.
// Ввод текста вместо числа не должно приводить к падению приложения, вместо этого, необходимо повторно запросить у
// пользователя ввод данных.

float NumberFloat ()
{
  float resNum = 0; 
  System.Console.Write("Введите дробное число: ");
  while (! float.TryParse(Console.ReadLine(), out resNum))
  {
    System.Console.WriteLine("Вы ввели не числовое значение! Введите дробное число: ");
  }
  return resNum;
}

System.Console.WriteLine($"Вы ввели число {NumberFloat ()}");

// 2. Если необходимо, исправьте данный код:

// try {
//    int d = 0;
//    double catchedRes1 = intArray[8] / d;
//    System.out.println("catchedRes1 = " + catchedRes1);
// } catch (ArithmeticException e) {
//    System.out.println("Catching exception: " + e);
// }

System.Console.WriteLine("Начинаем");

int [] array = new int [9] {0, 1, 2, 3, 4, 5, 6, 7, 8};

try
{
  int d = 0;
  double catchedRes1 = array[8] / d;
  System.Console.WriteLine($"catchedRes1 = {catchedRes1}");
}
catch (ArithmeticException e)
{
  System.Console.WriteLine("Catching exception: " + e);
}
System.Console.WriteLine("Конец");

//3. Дан следующий код, исправьте его там, где требуется

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

main();

static void main()
{
    int a = 90;
    int b = 3;
    try
    {
        System.Console.WriteLine(a / b);
            printSum(23, 234);
            int[] abc = { 1, 2 };
            abc[3] = 9;
    }
    catch (NullReferenceException ex)
    {
        System.Console.WriteLine("Указатель не может указывать на null!");
    }
    catch (IndexOutOfRangeException ex)
    {
        System.Console.WriteLine("Массив выходит за пределы своего размера!");
    }
    catch (Exception ex)
    {
        System.Console.WriteLine("Что-то пошло не так...");
    }
}

static void printSum(int a, int b) 
{
    System.Console.WriteLine(a + b);
}

// 4. Разработайте программу, которая выбросит Exception, когда пользователь вводит пустую строку. 
// Пользователю должно показаться сообщение, что пустые строки вводить нельзя.

void notEmpty ()
{
    System.Console.Write("Введите строку: ");
    string words = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(words)) throw new Exception("Пустые строки вводить нельзя");
    else
    {
        System.Console.WriteLine(words);
    }
}

notEmpty();