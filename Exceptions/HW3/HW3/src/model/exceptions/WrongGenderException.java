package model.exceptions;

public class WrongGenderException extends MyException{
    public WrongGenderException() {
        super("Пол указан неверно!");
    }
}
