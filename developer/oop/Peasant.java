import java.util.ArrayList;

public class Peasant extends Units {
    public int arrowCount;
    public int bulletCount;
    public int spearCount;

    public Peasant(int initiative, int step, int arrowCount, int bulletCount, int spearCount, int x, int y) {
        super("Крестьянин", 0, 0, 0, initiative, step, false, x, y);
        this.arrowCount = arrowCount;
        this.bulletCount = bulletCount;
        this.spearCount = spearCount;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + "З:" + this.healthPoints + ", А:" + this.arrowCount;
    }

    @Override
    public void step(ArrayList<Units> enemyTeam, ArrayList<Units> myTeam) {
        Units tmp = nearest(enemyTeam);
        System.out.println(
                this.name + " nearst " + tmp.name + " distance is " + coordinates.countDistance(tmp.coordinates));
    }
}
