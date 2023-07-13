public class Rogue extends Units {
    public Rogue(int shieldPoints, int attackPoints, int attackStep, int initiative, int step) {
        super("Бандит", shieldPoints, attackPoints, attackStep, initiative, step,
                false);
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + this.healthPoints + " здоровья на текущий момент";
    }
}
