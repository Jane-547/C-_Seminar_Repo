package service;

import service.data.Gender;

public interface Service {

    String getLastname();
    String getName();
    String getPatronymic();
    String getBirthDate();
    Gender getGender();
    String  getPhoneNumber();
}
