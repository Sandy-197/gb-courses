public class Peasant extends Units {
    public int arrowCount;
    public int bulletCount;
    public int spearCount;

    public Peasant(int initiative, int step, int arrowCount, int bulletCount, int spearCount) {
        super("Крестьянин", 0, 0, 0, initiative, step, false);
        this.arrowCount = arrowCount;
        this.bulletCount = bulletCount;
        this.spearCount = spearCount;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + this.arrowCount + " стрел для лучника на текущий момент";
    }
}
