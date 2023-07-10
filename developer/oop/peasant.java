public class peasant extends units {
    public int arrowCount;
    public int bulletCount;
    public int spearCount;

    public peasant(int initiative, int step, int arrowCount, int bulletCount, int spearCount) {
        super("Крестьянин", 0, 0, 0, initiative, step, false);
        this.arrowCount = arrowCount;
        this.bulletCount = bulletCount;
        this.spearCount = spearCount;
    }
}
