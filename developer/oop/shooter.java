public class shooter extends units {
    private int bulletCountMax; // максимальное количество пуль
    public int bulletCount; // колво пуль, изначально задается максимальное при создании юнита.

    public shooter(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int bulletCountMax) {
        super("Снайпер", shieldPoints, attackPoints, attackStep, initiative, step, false);
        this.bulletCountMax = bulletCountMax;
        this.bulletCount = this.bulletCountMax;
    }
}
