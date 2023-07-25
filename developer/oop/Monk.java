import java.util.ArrayList;

public class Monk extends Units {
    // public int addHealthPoint; // Количество здоровья, которое добавляет юниту за
    // один ход.

    public Monk(int initiative, int step, int attackPoints, int x, int y) {
        super("Монах", 0, attackPoints, 0, initiative, step, true, x, y);
        // this.addHealthPoint = addHealthPoint;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + "З:" + this.healthPoints;
    }

    @Override
    public void step(ArrayList<Units> enemyTeam, ArrayList<Units> myTeam) {
        // ищем в своей команде того, кому хуже всего. и его лечим
        int health = 100;
        Units tmp = myTeam.get(0);

        for (Units units : myTeam) {
            if (!units.state.equals("Dead") && health > units.healthPoints) {
                health = units.healthPoints;
                tmp = units;
            }
        }
        if (health < 100) {
            tmp.setDamage(-this.attackPoints);
            this.state = "Busy";
            System.out.println(
                    this.name + " лечит " + tmp.name);
        }
        else
        {
            // Можно прописать атаку. если не нашли кого лечить.
        }
    }
}
