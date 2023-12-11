package view;

import model.exceptions.MyException;

import java.io.IOException;

public interface View {
    void start() throws IOException, MyException;
    void print(String text);
    void finish();
    String scan();
}
