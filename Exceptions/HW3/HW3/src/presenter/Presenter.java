package presenter;

import service.Formatter;
import service.data.Data;
import service.Service;
import ui.View;

public class Presenter {

    private View view;
    private Service service;


    public Presenter(View view) {
        this.view = view;
        service = new Formatter();
    }

    public void getInfo(String city) {
        String answer = service.get(city);
        view.print(answer);
    }
}
