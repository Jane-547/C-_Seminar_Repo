package view;

import model.exceptions.MyException;
import model.service.Service;
import model.service.write.Writable;
import presenter.Presenter;

import java.io.IOException;
import java.util.Scanner;

public class ConsoleUI implements View {

    private Presenter presenter;
    private Scanner scanner;
    private boolean work;

    public ConsoleUI() {
        scanner = new Scanner(System.in);
        presenter = new Presenter(this);
        work = true;
    }

    @Override
    public void start(){
        while (work) {
            try {
                hello();
                String data = scan();
                presenter.setData(data);
                if (data == null) {
                    throw new IOException("Вы не ввели данные");
                }
                else if (data.equals("0")) {
                    finish();
                } else {
                    try {
                        presenter.writeData(data);
                    } catch (MyException e) {
                        System.out.println(e.getMessage());
                    }
                }
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }

    private void hello() {
        System.out.println("Введите следующие данные в произвольном порядке, разделенные пробелом:");
        System.out.println("Фамилия Имя Отчество, дата рождения, номер телефона, пол");
        System.out.println("Форматы данных:");
        System.out.println("фамилия, имя, отчество - строки");
        System.out.println("дата_рождения - строка формата dd.mm.yyyy");
        System.out.println("номер_телефона - целое беззнаковое число без форматирования");
        System.out.println("пол - символ латиницей f или m.");
        System.out.println("Для выхода нажмите 0");
    }

    @Override
    public String scan() {
        return scanner.nextLine();
    }

    @Override
    public void print(String text) {
        System.out.println(text);
    }

    @Override
    public void finish() {
        System.out.println("Работа приложения завершена.");
        scanner.close();
        work = false;
    }

    public void setService(Service service) {
        presenter.setService(service);
    }

    public void setWritable(Writable writable) {
        presenter.setWritable(writable);
    }
}
