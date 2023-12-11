package model.exceptions;

public class NoDataException extends MyException{
    public NoDataException() {
        super("Одно из значений не содержит данных!");
    }
}
