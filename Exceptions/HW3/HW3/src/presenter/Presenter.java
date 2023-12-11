package presenter;

import model.exceptions.MyException;
import model.service.Service;
import model.service.write.Writable;
import view.View;

import java.io.IOException;

public class Presenter {

    private View view;
    private Service service;


    public Presenter(View view) {
        this.view = view;
    }

    public void setService(Service service) {
        this.service = service;
    }

    public void setData(String fromUser) {
        service.setData(fromUser);
    }
    public void writeData(String fromUser) throws MyException, IOException{
        String result = service.writeData(fromUser);
        String answer = result.toString();
        view.print(answer);
    }

    public void setWritable(Writable writable) {
        service.setWritable(writable);
    }
}
