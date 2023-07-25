
import java.util.ArrayList;

public class Archer extends Units {
    private int arrowCountMax; // максимальное количество стрел
    public int arrowCount; // колво стрел, изначально задается максимальное при создании юнита.

    public Archer(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int arrowCountMax,
            int x, int y) {
        super("Лучник", shieldPoints, attackPoints, attackStep, initiative, step, false, x, y);
        this.arrowCountMax = arrowCountMax;
        this.arrowCount = this.arrowCountMax;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + "З:" + this.healthPoints + ", А:" + this.arrowCount;
    }

    @Override
    public void step(ArrayList<Units> enemyTeam, ArrayList<Units> myTeam) {

        // Проверяем жив ли лучник, если мертв, то выходим.
        if (this.healthPoints == 0)
            return;
        // Проверяем колво стрел, если стрел нет, то выходим.
        if (this.arrowCount == 0)
            return;
        System.out.println("Ход лучника: ");
        System.out.println("Стрелы и жизнь есть идем дальше.");
        // Определяем ближайшего противника
        Units tmp = nearest(enemyTeam);
        System.out.println("Нашли врага -> " + tmp.name);
        // Наносим ему урон, но не половинный... а столько сколько у нас в атаке
        // записано у нашего юнита.
        this.state = "Attak";
        tmp.setDamage(this.attackPoints);
        System.out.println("Нанесли врагу " + tmp.name + " урон = " + this.attackPoints + ". Теперь его здоровье = "
                + tmp.healthPoints);
        // уменьшаем стрелы
        if (this.arrowCount > 0)
            this.arrowCount -= 1;
        // Проверяем есть ли у нас внтури команды Крестьянин (Peasant)
        for (Units myUnit : myTeam) {
            if (myUnit instanceof Peasant && myUnit.state.equals("Stand")) {
                Peasant temp = (Peasant) myUnit;
                if (temp.arrowCount > 0) {
                    this.arrowCount++;
                    temp.arrowCount--;
                }
                
                myUnit.state = "Busy";
                System.out.println("Крестьянин в комманде есть. Стрел осталось " + this.arrowCount);

                return;
            }
        }

        System.out.println("Крестьянина нет. Стрел осталось " + this.arrowCount);
    }
}
