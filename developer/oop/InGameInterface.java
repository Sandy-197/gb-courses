import java.util.ArrayList;

public interface InGameInterface {
    void step(ArrayList<Units> enemyTeam, ArrayList<Units> myTeam);

    String getInfo();

    String getName();

    Coordinates getCoordinates();

    boolean setDamage(int damage);
}
