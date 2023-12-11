package model.service;

import model.exceptions.*;
import model.service.data.Data;
import model.service.data.Gender;
import model.service.write.Writable;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class Formatter implements Service {
    private List<String> allValues;
    private Service service;
    private Writable writable;

    public Formatter() {
        this.allValues = new ArrayList<>();
    }

    @Override
    public void setData(String fromUser) {
        this.allValues = new ArrayList<>(List.of(fromUser.split(" ")));
    }

    @Override
    public Data parse() throws MyException{
        Gender gender = getGender();
        String birthDate = getBirthDate();
        String phoneNumber = getPhoneNumber();
        String lastName = getLastName(getFio());
        String name = getName(getFio());
        String patronymic = getPatronymic(getFio());
        if (gender == null || birthDate == null || phoneNumber == null || lastName == null || name == null || patronymic == null) {
            throw new NoDataException();
        }
        return new Data(lastName, name, patronymic, birthDate, gender, phoneNumber);
    }

    @Override
    public int getDataLength() throws FewDataException, MuchDataException {
        int err = 0;
        if (allValues.size() < 6) {
            err = -1;
        } else if (allValues.size() > 6) {
            err = -2;
        }
        checkData(err);
        return err;
    }

    @Override
    public boolean checkData(int err) throws FewDataException, MuchDataException {
        boolean d = false;
        if (err == -1) {
            throw new FewDataException();
        } else if (err == -2) {
            throw new MuchDataException();
        } else d = true;
        return d;
    }


    @Override
    public Gender getGender() throws WrongGenderException {
        Gender gender = null;
        for (String value : allValues) {
            if (value.equals("f") || value.equals("m")) {
                gender = Gender.valueOf(value);
            }
        }
        if (gender == null) {
            throw new WrongGenderException();
        }
        return gender;
    }

    @Override
    public String getBirthDate() throws MyException{
        String birthDate = null;
        for (String value : allValues) {
            if (dateIsValid(value) != null) {
                birthDate = value;
            }
        }
        if (birthDate == null) {
            throw new WrongDateException();
        }
        return birthDate;
    }

    private Date dateIsValid(String value) {
        try {
            SimpleDateFormat dateFormat = new SimpleDateFormat("dd.MM.yyyy");
            dateFormat.setLenient(false);
            return dateFormat.parse(value.trim());
        } catch (ParseException pe) {
            return null;
        }
    }

    @Override
    public String getPhoneNumber() throws WrongPhonenumberException {
        String phoneNumber = null;
        for (String value : allValues) {
            if (phoneIsValid(value) != null) {
                phoneNumber = value;
                return phoneNumber;
            }
        }
        if (phoneNumber == null) {
            throw new WrongPhonenumberException();
        }
        return phoneNumber;
    }

    private String phoneIsValid(String value) throws WrongPhonenumberException {
        try {
            if (value.matches("[0-9]+")) {
                return value;
            }
        } catch (NumberFormatException e) {
            throw new WrongPhonenumberException();
        }
        return null;
    }

    @Override
    public List<String> getFio() throws MyException{
        List<String> fio = new ArrayList<>();
        for (String value : allValues) {
            if (!value.equals("f") && !value.equals("m") && dateIsValid(value) == null && phoneIsValid(value) == null) {
                fio.add(value);
            }
        }
        if (fio.size() < 3) {
            throw new WrongFioException();
        }
        return fio;
    }

    @Override
    public String getLastName(List<String> fio) {
        return fio.get(0);
    }

    @Override
    public void setWritable(Writable writable) {
        this.writable = writable;
    }

    @Override
    public String writeData(String fromUser) throws MyException, IOException{
        service = this;
        Data result = new Data();
        if (service.getDataLength() == 0) {
            result = service.parse();
            if (result == null) {
                throw new WriterException();
            }
            writable.write(result);
        }
        return result.toString();
    }

    private String getName(List<String> fio) {
        return fio.get(1);
    }

    private String getPatronymic(List<String> fio) {
        return fio.get(2);
    }
}
