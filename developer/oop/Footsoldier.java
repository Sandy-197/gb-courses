import java.util.ArrayList;

public class Footsoldier extends Units {
    private int bulletCountMax; // максимальное количество пуль
    public int bulletCount; // колво пуль, изначально задается максимальное при создании юнита.

    public Footsoldier(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int bulletCountMax,
            int x, int y) {
        super("Пехотинец", shieldPoints, attackPoints, attackStep, initiative, step, false, x, y);
        this.bulletCountMax = bulletCountMax;
        this.bulletCount = this.bulletCountMax;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + "З:" + this.healthPoints + ", Б:" + this.bulletCount;
    }

    // Делаем ход пехоты!
    // 1. Проверяем здоровье
    // 2. Ищем ближайшего врага
    // 3. Двигаемся в сторну врага
    // 4. Не наступаем на живых персонажей
    // 5. Если расстояние до врага одна клетка бём его!
    @Override
    public void step(ArrayList<Units> enemyTeam, ArrayList<Units> myTeam) {
        // Проверяем жив ли лучник, если мертв, то выходим.
        if (this.healthPoints == 0)
            return;
        // Проверяем колво стрел, если стрел нет, то выходим.
        if (this.bulletCount == 0)
            return;
        System.out.println("Ход пехотинца: ");
        System.out.println("Пули и жизнь есть идем дальше.");
        // Ищем ближайшего
        Units tmp = nearest(enemyTeam);

        double dist = this.coordinates.countDistance(tmp.getCoordinates());
        System.out.println("Нашли врага -> " + tmp.name + ". Расстояние " + dist);
        if (dist < 2) {
            this.state = "Attak";
            tmp.setDamage(this.attackPoints);
            if (this.bulletCount > 0)
                this.bulletCount -= 1;
            // Проверяем есть ли у нас внтури команды Крестьянин (Peasant)
            for (Units myUnit : myTeam) {
                if (myUnit instanceof Peasant && myUnit.state.equals("Stand")) {
                    Peasant temp = (Peasant) myUnit;
                    if (temp.bulletCount > 0) {
                        this.bulletCount++;
                        temp.bulletCount--;
                    }
                    myUnit.state = "Busy";
                    System.out.println("Крестьянин в комманде есть. Пуль осталось " + this.bulletCount);
                    return;
                }
            }
            System.out.println("Крестьянина нет. Пуль осталось " + this.bulletCount);
        } else {
            this.state = "Move";
            int dist_x = this.coordinates.x - tmp.coordinates.x;
            int dist_y = this.coordinates.y - tmp.coordinates.y;
            if (dist_x < 0 && dist_y < 0) {
                
                this.coordinates.x++;
                this.coordinates.y++;

                // this.coordinates.y++;
                
                // this.coordinates.x++;
                
            }
            if (dist_x < 0 && dist_y > 0) {
                this.coordinates.x++;
                this.coordinates.y--;
            }
            if (dist_x > 0 && dist_y < 0) {
                this.coordinates.x--;
                this.coordinates.y++;
            }
            if (dist_x > 0 && dist_y > 0) {
                this.coordinates.x--;
                this.coordinates.y--;
            }

            // Coordinates dst[] = new Coordinates[8];
            // dst[0] = new Coordinates(this.coordinates.x - 1, this.coordinates.y - 1);
            // dst[1] = new Coordinates(this.coordinates.x, this.coordinates.y - 1);
            // dst[2] = new Coordinates(this.coordinates.x + 1, this.coordinates.y - 1);
            // dst[3] = new Coordinates(this.coordinates.x - 1, this.coordinates.y);
            // dst[4] = new Coordinates(this.coordinates.x + 1, this.coordinates.y);
            // dst[5] = new Coordinates(this.coordinates.x - 1, this.coordinates.y + 1);
            // dst[6] = new Coordinates(this.coordinates.x, this.coordinates.y + 1);
            // dst[7] = new Coordinates(this.coordinates.x + 1, this.coordinates.y + 1);
            // for (Units unit : enemyTeam) {
            // if (unit.coordinates.x -
            // }
        }

    }
}
