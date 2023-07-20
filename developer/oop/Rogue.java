import java.util.ArrayList;

public class Rogue extends Units {
    public Rogue(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int x, int y) {
        super("Бандит", shieldPoints, attackPoints, attackStep, initiative, step,
                false, x, y);
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + this.healthPoints + " здоровья на текущий момент";
    }

    @Override
    public void step(ArrayList<Units> enemyTeam, ArrayList<Units> myTeam)
    {
        Units tmp = nearest(enemyTeam);
        System.out.println(this.name + " nearst " +tmp.name+ " distance is "+ coordinates.countDistance(tmp.coordinates));
    }
}
