import model.service.Formatter;
import model.service.write.FileHandler;
import view.ConsoleUI;

public class Main {
    public static void main(String[] args){
        ConsoleUI test = new ConsoleUI();
        test.setService(new Formatter());
        test.setWritable(new FileHandler());
        test.start();
    }
}