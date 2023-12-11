package model.exceptions;

public class WriterException extends MyException{
    public WriterException() {
        super("Запись данных в файл невозможна!");
    }
}


