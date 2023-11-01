import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        System.out.println("Введите следующие данные в произвольном порядке, разделенные пробелом:\n" +
                "Фамилия Имя Отчество, дата рождения, номер телефона, пол\n" +
                "Форматы данных:\n" +
                "фамилия, имя, отчество - строки\n" +
                "\n" +
                "дата_рождения - строка формата dd.mm.yyyy\n" +
                "\n" +
                "номер_телефона - целое беззнаковое число без форматирования\n" +
                "\n" +
                "пол - символ латиницей f или m.");
        Scanner sc = new Scanner(System.in);
        String fromUser = sc.nextLine();


    }
}