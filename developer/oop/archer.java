public class archer extends units {
    private int arrowCountMax; // максимальное количество стрел
    public int arrowCount; // колво стрел, изначально задается максимальное при создании юнита.

    public archer(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int arrowCountMax) {
        super("Лучник", shieldPoints, attackPoints, attackStep, initiative, step, false);
        this.arrowCountMax = arrowCountMax;
        this.arrowCount = this.arrowCountMax;
    }
}
