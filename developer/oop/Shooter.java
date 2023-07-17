import java.util.ArrayList;

public class Shooter extends Units {
    private int bulletCountMax; // максимальное количество пуль
    public int bulletCount; // колво пуль, изначально задается максимальное при создании юнита.

    public Shooter(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int bulletCountMax,
            int x, int y) {
        super("Снайпер", shieldPoints, attackPoints, attackStep, initiative, step, false, x, y);
        this.bulletCountMax = bulletCountMax;
        this.bulletCount = this.bulletCountMax;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + this.bulletCount + " пуль на текущий момент";
    }
    @Override
    public void step(ArrayList<Units> units)
    {
        Units tmp = nearest(units);
        System.out.println(this.name + " nearst " +tmp.name+ " distance is "+ coordinates.countDistance(tmp.coordinates));
    }
}
