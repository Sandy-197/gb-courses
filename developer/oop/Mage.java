import java.util.ArrayList;

public class Mage extends Units {
    public int manaCount; // Количество волшебного вещества.

    public Mage(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int manaCount, int x,
            int y) {
        super("Маг", shieldPoints, attackPoints, attackStep, initiative, step, false, x, y);
        this.manaCount = manaCount;

    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + "З:" + this.healthPoints + ", М:" + this.manaCount;
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
                    this.name + " лечит " + tmp.name + " Здоровье стало:" + tmp.healthPoints);
        }
        else
        {
            // Можно прописать атаку. если не нашли кого лечить.
        }
    }
}
