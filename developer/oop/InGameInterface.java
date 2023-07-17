import java.util.ArrayList;

public interface InGameInterface {
    void step(ArrayList<Units> units);

    String getInfo();

    String getName();

    Coordinates GetCoordinates();
}
