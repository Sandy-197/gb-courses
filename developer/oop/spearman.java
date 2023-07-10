public class spearman extends units {
    private int spearCountMax; // максимальное количество копий
    public int spearCount; // колво копий, изначально задается максимальное при создании юнита.

    public spearman(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int spearCountMax) {
        super("Копейщик", shieldPoints, attackPoints, attackStep, initiative, step, false);
        this.spearCountMax = spearCountMax;
        this.spearCount = this.spearCountMax;
    }
}
