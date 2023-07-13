public class Spearman extends Units {
    private int spearCountMax; // максимальное количество копий
    public int spearCount; // колво копий, изначально задается максимальное при создании юнита.

    public Spearman(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int spearCountMax) {
        super("Копейщик", shieldPoints, attackPoints, attackStep, initiative, step, false);
        this.spearCountMax = spearCountMax;
        this.spearCount = this.spearCountMax;
    }
    @Override
    public String getInfo()
    {
        return this.name+" имеет "+this.spearCount+" копий на текущий момент";
    }
}
