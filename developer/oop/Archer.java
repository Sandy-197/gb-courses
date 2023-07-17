import java.lang.reflect.Array;
import java.util.ArrayList;

public class Archer extends Units {
    private int arrowCountMax; // максимальное количество стрел
    public int arrowCount; // колво стрел, изначально задается максимальное при создании юнита.

    public Archer(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int arrowCountMax,
            int x, int y) {
        super("Лучник", shieldPoints, attackPoints, attackStep, initiative, step, false, x, y);
        this.arrowCountMax = arrowCountMax;
        this.arrowCount = this.arrowCountMax;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + this.arrowCount + " стрел на текущий момент";
    }

    @Override
    public void step(ArrayList<Units> units)
    {
        Units tmp = nearest(units);
        System.out.println(this.name + " nearst " +tmp.name+ " distance is "+ coordinates.countDistance(tmp.coordinates));
    }
}
