package service;

import service.data.Data;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.nio.file.FileSystemException;

public class FileHandler {

    public void write(Data data) throws FileSystemException {
        String fileName = "src\\files\\" + data.getLastname().toLowerCase() + ".txt";
        File file = new File(fileName);
        try (FileWriter fileWriter = new FileWriter(file, true)){
            if (file.length() > 0){
                fileWriter.write('\n');
            }
            fileWriter.write(data.toString());
        }catch (IOException e){
            throw new FileSystemException("Возникла ошибка при работе с файлом");
        }
    }
}
