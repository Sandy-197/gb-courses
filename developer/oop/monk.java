public class monk extends units {
    public int addHealthPoint; // Количество здоровья, которое добавляет юниту за один ход.

    public monk(int initiative, int step, int addHealthPoint) {
        super("Монах", 0, 0, 0, initiative, step, true);
        this.attackPoints = addHealthPoint;
    }
}
