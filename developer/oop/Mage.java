public class Mage extends Units {
    public int manaCount; // Количество волшебного вещества.

    public Mage(int shieldPoints, int attackPoints, int attackStep, int initiative, int step, int manaCount) {
        super("Маг", shieldPoints, attackPoints, attackStep, initiative, step, false);
        this.manaCount = manaCount;
 
    }
    @Override
    public String getInfo()
    {
        return this.name+" имеет "+this.manaCount+" маны на текущий момент";
    }
}
