package model.exceptions;

public class FewDataException extends MyException{
    public FewDataException() {
        super("Вы ввели недостаточно данных!");
    }
}

