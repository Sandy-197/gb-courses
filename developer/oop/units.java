abstract public class Units implements InGameInterface {
    public String name; // название юнита
    public int healthPoints; // общее здоровье, начальное значение всегда 100%
    public int shieldPoints; // количество щита, у каждого юнита оно разное
    public int attackPoints; // количество урона, которое наносит атака юнита
    public int attackStep; // количетсво клеток, через которые может идти атака
    public int initiative; // инициатива, порядок атаки
    public int step; // кол-во клеток, на которое может передвигаться юнит
    public boolean canHealth; // может ли юнит лечить

    public Units(String name, int shieldPoints, int attackPoints, int attackStep, int initiative, int step,
            boolean canHealth) {
        this.name = name;
        this.healthPoints = 100;
        this.shieldPoints = shieldPoints;
        this.attackPoints = attackPoints;
        this.attackStep = attackStep;
        this.initiative = initiative;
        this.step = step;
        this.canHealth = canHealth;
    }

    @Override
    public String getName() {
        return this.name;
    }

    public void step() {

    }
}
