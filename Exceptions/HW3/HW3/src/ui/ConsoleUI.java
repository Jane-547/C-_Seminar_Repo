package ui;

import presenter.Presenter;

import java.util.Scanner;

public class ConsoleUI implements View{

    private Presenter presenter;
    private Scanner scanner;
    private boolean work;

    public ConsoleUI() {
        scanner = new Scanner(System.in);
        presenter = new Presenter(this);
        work = true;
    }

    @Override
    public void start() {
        while (work){
            String data = hello();
            presenter.getInfo(city);
        }
    }

    private String hello () {
        System.out.println("Введите следующие данные в произвольном порядке, разделенные пробелом:");
        System.out.println("Фамилия Имя Отчество, дата рождения, номер телефона, пол");
        System.out.println("Форматы данных:");
        System.out.println("фамилия, имя, отчество - строки");
        System.out.println("дата_рождения - строка формата dd.mm.yyyy");
        System.out.println("номер_телефона - целое беззнаковое число без форматирования");
        System.out.println("пол - символ латиницей f или m.");
        return scanner.nextLine();
    }
    private String scan() {
        System.out.println("Введите город");
        return scanner.nextLine();
    }

    @Override
    public void print(String text) {
        System.out.println(text);
    }

    @Override
    public void finish() {

    }
}
