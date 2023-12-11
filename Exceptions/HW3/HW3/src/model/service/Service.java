package model.service;

import model.exceptions.*;
import model.service.data.Data;
import model.service.data.Gender;
import model.service.write.Writable;

import java.io.IOException;
import java.text.ParseException;
import java.util.List;

public interface Service {

    Data parse() throws MyException;
    boolean checkData(int err) throws MyException;
    int getDataLength() throws IOException, MyException;
    Gender getGender() throws WrongGenderException;
    String getBirthDate() throws MyException, ParseException;
    String getPhoneNumber() throws WrongPhonenumberException;
    List<String> getFio() throws MyException, ParseException;
    String getLastName(List<String> fio);
    void setWritable(Writable writable);
    String writeData(String fromUser) throws MyException, IOException;
    void setData(String fromUser);
}
