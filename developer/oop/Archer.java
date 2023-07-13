public class Archer extends Units {
    private int arrowCountMax; // максимальное количество стрел
    public int arrowCount; // колво стрел, изначально задается максимальное при создании юнита.

    public Archer(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int arrowCountMax) {
        super("Лучник", shieldPoints, attackPoints, attackStep, initiative, step, false);
        this.arrowCountMax = arrowCountMax;
        this.arrowCount = this.arrowCountMax;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + this.arrowCount + " стрел на текущий момент";
    }
}
