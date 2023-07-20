import java.util.ArrayList;

public class Monk extends Units {
    public int addHealthPoint; // Количество здоровья, которое добавляет юниту за один ход.

    public Monk(int initiative, int step, int addHealthPoint, int x, int y) {
        super("Монах", 0, 0, 0, initiative, step, true, x, y);
        this.addHealthPoint = addHealthPoint;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + "З:" + this.healthPoints;
    }

    @Override
    public void step(ArrayList<Units> enemyTeam, ArrayList<Units> myTeam)
    {
        Units tmp = nearest(enemyTeam);
        System.out.println(this.name + " nearst " +tmp.name+ " distance is "+ coordinates.countDistance(tmp.coordinates));
    }
}
