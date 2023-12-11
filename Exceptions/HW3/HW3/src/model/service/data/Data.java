package model.service.data;


public class Data{
    private String lastname;
    private String name;
    private String patronymic;
    private String birthDate;
    private Gender gender;
    private String phoneNumber;

    public Data(String lastname, String name, String patronymic, String birthDate, Gender gender, String phoneNumber) {
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
        this.phoneNumber = null;
    }

    public String getLastname() {
        return lastname;
    }

    public String getName() {
        return name;
    }

    public String getPatronymic() {
        return patronymic;
    }

    public String getBirthDate() {
        return birthDate;
    }

    public Gender getGender() {
        return gender;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    @Override
    public String toString() {
        return "<" + lastname + "><" + name + "><" + patronymic + "><" + birthDate + "><" + phoneNumber + "><" + gender + ">";

    }
}
