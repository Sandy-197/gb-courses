import java.util.ArrayList;

public class Monk extends Units {
    public int addHealthPoint; // Количество здоровья, которое добавляет юниту за один ход.

    public Monk(int initiative, int step, int addHealthPoint, int x, int y) {
        super("Монах", 0, 0, 0, initiative, step, true, x, y);
        this.addHealthPoint = addHealthPoint;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + this.addHealthPoint + " здорове на текущий момент";
    }

    @Override
    public void step(ArrayList<Units> units)
    {
        Units tmp = nearest(units);
        System.out.println(this.name + " nearst " +tmp.name+ " distance is "+ coordinates.countDistance(tmp.coordinates));
    }
}
