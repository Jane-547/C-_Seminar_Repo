package model.service.write;

import model.service.data.Data;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class FileHandler implements Writable{

    @Override
    public void write(Data data) throws IOException {
        String fileName = "src\\output\\" + data.getLastname().toLowerCase() + ".txt";
        File file = new File(fileName);
        try (FileWriter fileWriter = new FileWriter(file, true)){
            if (file.length() > 0){
                fileWriter.write('\n');
            }
            fileWriter.write(data.toString());
        }
    }
}
