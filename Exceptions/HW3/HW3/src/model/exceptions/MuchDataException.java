package model.exceptions;

public class MuchDataException extends MyException{
    public MuchDataException() {
        super("Вы ввели слишком много данных!");
    }
}

