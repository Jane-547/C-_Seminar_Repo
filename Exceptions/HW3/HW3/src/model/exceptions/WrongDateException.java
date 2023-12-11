package model.exceptions;

public class WrongDateException extends MyException{
    public WrongDateException() {
        super("Неверный формат даты!");
    }
}

