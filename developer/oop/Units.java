import java.util.ArrayList;

abstract public class Units implements InGameInterface {
    public String name; // название юнита
    public int healthPoints; // общее здоровье, начальное значение всегда 100%
    public int shieldPoints; // количество щита, у каждого юнита оно разное
    public int attackPoints; // количество урона, которое наносит атака юнита
    public int attackStep; // количетсво клеток, через которые может идти атака
    public int initiative; // инициатива, порядок атаки
    public int step; // кол-во клеток, на которое может передвигаться юнит
    public boolean canHealth; // может ли юнит лечить
    public Coordinates coordinates;

    public Units(String name, int shieldPoints, int attackPoints, int attackStep, int initiative, int step,
            boolean canHealth, int x, int y) {
        this.name = name;
        this.healthPoints = 100;
        this.shieldPoints = shieldPoints;
        this.attackPoints = attackPoints;
        this.attackStep = attackStep;
        this.initiative = initiative;
        this.step = step;
        this.canHealth = canHealth;
        this.coordinates = new Coordinates(x, y);
    }

    @Override
    public String getName() {
        return this.name;
    }

    public Units nearest(ArrayList<Units> unit) {
        double nearestDistance = Double.MAX_VALUE;
        int nearestUnit = 0;
        for (int i = 0; i < unit.size(); i++) {
            double cd = coordinates.countDistance(unit.get(i).coordinates);
            if (cd < nearestDistance) {
                nearestDistance = cd;
                nearestUnit = i;
            }
        }
        return unit.get(nearestUnit);
    }

}
