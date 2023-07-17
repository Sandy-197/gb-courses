import java.util.ArrayList;

public class Spearman extends Units {
    private int spearCountMax; // максимальное количество копий
    public int spearCount; // колво копий, изначально задается максимальное при создании юнита.

    public Spearman(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int spearCountMax,
            int x, int y) {
        super("Копейщик", shieldPoints, attackPoints, attackStep, initiative, step, false, x, y);
        this.spearCountMax = spearCountMax;
        this.spearCount = this.spearCountMax;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + this.spearCount + " копий на текущий момент";
    }

    @Override
    public void step(ArrayList<Units> units)
    {
        Units tmp = nearest(units);
        System.out.println(this.name + " nearst " +tmp.name+ " distance is "+ coordinates.countDistance(tmp.coordinates));
    }
}
