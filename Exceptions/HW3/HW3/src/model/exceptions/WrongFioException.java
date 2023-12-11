package model.exceptions;

public class WrongFioException extends MyException{
    public WrongFioException() {
        super("Неверный формат ФИО!");
    }
}

