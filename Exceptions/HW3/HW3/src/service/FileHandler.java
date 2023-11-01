package service;

public class FileHandler {
    String fileName = "files\\" + surname.toLowerCase() + ".txt";
    File file = new File(fileName);
        try (FileWriter fileWriter = new FileWriter(file, true)){
        if (file.length() > 0){
            fileWriter.write('\n');
        }
        fileWriter.write(String.format("%s %s %s %s %s %s", surname, name, patronymic, format.format(birthdate), phone, sex));
    }catch (IOException e){
        throw new FileSystemException("Возникла ошибка при работе с файлом");
    }
}
