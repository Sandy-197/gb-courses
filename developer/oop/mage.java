public class mage extends units {
    public int manaCount; // Количество волшебного вещества.

    public mage(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int manaCount) {
        super("Маг", shieldPoints, attackPoints, attackStep, initiative, step, false);
        this.manaCount = manaCount;
    }
}
