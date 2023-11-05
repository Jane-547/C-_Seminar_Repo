package service;

import exception.MyException;
import service.data.Data;
import service.data.Gender;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class Formatter {
    private List<String> allValues;

    public Formatter(String fromUser) {
        this.allValues = new ArrayList<>(List.of(fromUser.split(" ")));
    }

    public Data parse() {
        try {
            Gender gender = getGender();
            String birthDate = getBirthDate();
            String phoneNumber = getPhoneNumber();
            String lastName = getLastName(getFio());
            String name = getName(getFio());
            String patronymic = getPatronymic(getFio());
            if (gender == null || birthDate == null || phoneNumber == null || lastName == null || name == null || patronymic == null) {
                throw new MyException("Одно из значений не содержит данных!");
            }
            return new Data(lastName, name, patronymic, birthDate, gender, phoneNumber);
        } catch (MyException e) {
            System.out.println(e.getMessage());
        }
        return null;
    }

    public int getDataLength() {
        int err = 0;
        if (allValues.size() < 6) {
            err = -1;
        } else if (allValues.size() > 6) {
            err = -2;
        }
        checkData(err);
        return err;
    }

    private void checkData(int err) {
        try {
            if (err == -1) {
                throw new IOException("Недостаточно данных!");
            } else if (err == -2) {
                throw new IOException("Данных больше, чем требуется программе!");
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }


    private Gender getGender() {
        Gender gender = null;
        for (String value : allValues) {
            if (value.equals("f") || value.equals("m")) {
                gender = Gender.valueOf(value);
            }
        }
        try {
            if (gender == null) {
                throw new MyException("Пол указан неверно!");
            }
        } catch (MyException e) {
            System.out.println(e.getMessage());
        }
        return gender;
    }

    private String getBirthDate() {
        String birthDate = null;
        for (String value : allValues) {
            if (dateIsValid(value) != null) {
                birthDate = value;
            }
        }
        try {
            if (birthDate == null) {
                throw new MyException("Неверный формат даты!");
            }
        } catch (MyException e) {
            System.out.println(e.getMessage());
        }
        return birthDate;
    }

    private Date dateIsValid(String value) {
        SimpleDateFormat dateFormat = new SimpleDateFormat("dd.MM.yyyy");
        try {
            return dateFormat.parse(value.trim());
        } catch (ParseException pe) {
            return null;
        }
    }

    private String getPhoneNumber() {
        String phoneNumber = null;
        for (String value : allValues) {
            if (phoneIsValid(value) != null) {
                phoneNumber = value;
                return phoneNumber;
            }
        }
        try {
            if (phoneNumber == null) {
                throw new MyException("Неверный формат номера телефона!");
            }
        } catch (MyException e) {
            System.out.println(e.getMessage());
        }
        return phoneNumber;
    }

    private String phoneIsValid(String value) {
        try {
            if (value.matches("[0-9]+")) {
                return value;
            }
        } catch (NumberFormatException e) {
            return null;
        }

        return null;
    }

    private List<String> getFio() {
        List<String> fio = new ArrayList<>();
        for (String value : allValues) {
            if (!value.equals("f") && !value.equals("m") && dateIsValid(value) == null && phoneIsValid(value) == null) {
                fio.add(value);
            }
        }
        try {
            if (fio.size() < 3) {
                throw new MyException("Неверный формат ФИО");
            }
        } catch (MyException e) {
            System.out.println(e.getMessage());
        }
        return fio;
    }

    private String getLastName(List<String> fio) {
        return fio.get(0);
    }

    private String getName(List<String> fio) {
        return fio.get(1);
    }

    private String getPatronymic(List<String> fio) {
        return fio.get(2);
    }
}
