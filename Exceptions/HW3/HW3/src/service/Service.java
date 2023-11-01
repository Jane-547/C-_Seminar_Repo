package service;

import service.data.Gender;

import java.time.LocalDate;

public interface Service {

    String getLastname();
    String getName();
    String getPatronymic();
    LocalDate getBirthDate();
    Gender getGender();
    int getPhoneNumber();
}
