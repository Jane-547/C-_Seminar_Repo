package presenter;

import exception.MyException;
import service.FileHandler;
import service.Formatter;
import service.data.Data;
import ui.View;

import java.io.IOException;

public class Presenter {

    private View view;



    public Presenter(View view) {
        this.view = view;
    }

    public void writeData(String fromUser) {
        Formatter formatter = new Formatter(fromUser);
        try {
            if (formatter.getDataLength() == 0) {
                try {
                    Data result = formatter.parse();
                    if (result == null) {
                        throw new MyException("Запись данных в файл невозможна!");
                    }
                    String answer = result.toString();
                    view.print(answer);
                    FileHandler fh = new FileHandler();
                    fh.write(result);
                } catch (MyException e) {
                    System.out.println(e.getMessage());
                }
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
