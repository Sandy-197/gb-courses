import java.util.ArrayList;

public class Peasant extends Units {
    public int arrowCount;
    public int bulletCount;
    public int spearCount;
    public int inTeam; // так как может быть в двух командах

    public Peasant(int initiative, int step, int arrowCount, int bulletCount, int spearCount, int inTeam, int x,
            int y) {
        super("Крестьянин", 0, 0, 0, initiative, step, false, x, y);
        this.arrowCount = arrowCount;
        this.bulletCount = bulletCount;
        this.spearCount = spearCount;
        this.inTeam = inTeam;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + "З:" + this.healthPoints + ", А:" + this.arrowCount;
    }

    @Override
    public void step(ArrayList<Units> enemyTeam, ArrayList<Units> myTeam) {
        System.out.println("Крестьянин был " + this.state);
        if (this.state.equals("Busy"))
            this.state = "Stand";
        System.out.println("Крестьянин стал " + this.state);
    }
}
