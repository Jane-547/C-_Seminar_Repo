package service.data;

import service.Service;

import java.time.LocalDate;

public class Data implements Service {
    private String lastname;
    private String name;
    private String patronymic;
    private LocalDate birthDate;
    private Gender gender;
    private int phoneNumber;

    public Data(String lastname, String name, String patronymic, LocalDate birthDate, Gender gender, int phoneNumber) {
        this.lastname = lastname;
        this.name = name;
        this.patronymic = patronymic;
        this.birthDate = birthDate;
        this.gender = gender;
        this.phoneNumber = phoneNumber;
    }

    public Data() {
        this.lastname = null;
        this.name = null;
        this.patronymic = null;
        this.birthDate = null;
        this.gender = null;
        this.phoneNumber = 0;
    }

    @Override
    public String getLastname() {
        return lastname;
    }

    @Override
    public String getName() {
        return name;
    }

    @Override
    public String getPatronymic() {
        return patronymic;
    }

    @Override
    public LocalDate getBirthDate() {
        return birthDate;
    }

    @Override
    public Gender getGender() {
        return gender;
    }

    @Override
    public int getPhoneNumber() {
        return phoneNumber;
    }
}
