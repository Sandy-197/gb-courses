public class Shooter extends Units {
    private int bulletCountMax; // максимальное количество пуль
    public int bulletCount; // колво пуль, изначально задается максимальное при создании юнита.

    public Shooter(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int bulletCountMax) {
        super("Снайпер", shieldPoints, attackPoints, attackStep, initiative, step, false);
        this.bulletCountMax = bulletCountMax;
        this.bulletCount = this.bulletCountMax;
    }
    @Override
    public String getInfo()
    {
        return this.name+" имеет "+this.bulletCount+" пуль на текущий момент";
    }
}
