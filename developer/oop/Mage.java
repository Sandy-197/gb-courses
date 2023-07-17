import java.util.ArrayList;

public class Mage extends Units {
    public int manaCount; // Количество волшебного вещества.

    public Mage(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int manaCount, int x,
            int y) {
        super("Маг", shieldPoints, attackPoints, attackStep, initiative, step, false, x, y);
        this.manaCount = manaCount;

    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + this.manaCount + " маны на текущий момент";
    }

    @Override
    public void step(ArrayList<Units> units)
    {
        Units tmp = nearest(units);
        System.out.println(this.name + " nearst " +tmp.name+ " distance is "+ coordinates.countDistance(tmp.coordinates));
    }
}
