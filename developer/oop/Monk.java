public class Monk extends Units {
    public int addHealthPoint; // Количество здоровья, которое добавляет юниту за один ход.

    public Monk(int initiative, int step, int addHealthPoint) {
        super("Монах", 0, 0, 0, initiative, step, true);
        this.addHealthPoint = addHealthPoint;
    }

    @Override
    public String getInfo() {
        return this.name + " имеет " + this.addHealthPoint + " здорове на текущий момент";
    }
}
