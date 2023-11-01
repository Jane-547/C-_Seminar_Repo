package service;

import service.data.Data;

import java.util.ArrayList;
import java.util.List;

public class Formatter {
    private List<String> allValues;

    public Formatter(String fromUser) {
        this.allValues = new ArrayList<>(List.of(fromUser.split(" ")));
    }

    public Data parse (String data) {
        Data human = new Data();

        return human;
    }

    public void searchGender() {

    }

}
