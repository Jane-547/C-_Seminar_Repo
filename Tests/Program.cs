System.Console.WriteLine("Задание 15");

System.Console.WriteLine("Введите число обозначающее день недели от 1 до 7 ");

int number = int.Parse(Console.ReadLine());

if (number>5)
{
    System.Console.WriteLine("Да");
}
else if(number<=5)
{
   System.Console.WriteLine("Нет");
}
else
{
    System.Console.WriteLine("Это число не в диапазоне от 1 до 7");
}