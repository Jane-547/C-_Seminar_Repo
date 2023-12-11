package model.service.write;

import model.service.data.Data;

import java.io.IOException;

public interface Writable {
    void write(Data data) throws IOException;
}
