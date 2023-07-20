
import java.util.ArrayList;
import java.util.Random;

public class Program {
    private static int countInTeam = 10; // Кол-во персонажей в команде
    private static ArrayList<Units> teamOne;
    private static ArrayList<Units> teamTwo;

    public static void main(String[] args) {
        // hw1(); // Домашка 1
        // hw2(); // Домашка 2
        hw4(); // Домашка 4
    }

    public static void hw4() {
        System.out.println("Домашка 4:");

        teamOne = generateTeam(countInTeam, true);
        teamTwo = generateTeam(countInTeam, false);

        System.out.println("Team One Members:");
        for (Units units : teamOne) {
            System.out.println(units.name);
        }
        System.out.println("----------------");
        System.out.println("Team Two Members:");
        for (Units units : teamTwo) {
            System.out.println(units.name);
        }
        System.out.println("----------------");

        for (Units unit : teamOne) {
            // System.out.println(unit.getName());
            if (unit.getName().equals("Лучник")) {
                System.out.println("Лучник ходит");
                unit.step(teamTwo, teamOne);
            }
        }

        System.out.println();
        System.out.println("Выводим информацию о первой команде:");
        PrintSortedInitiative(teamOne);

        System.out.println();
        System.out.println("Выводим информацию о второй команде:");
        PrintSortedInitiative(teamTwo);
    }

    public static void hw2() {
        System.out.println("Домашка 3:");

        teamOne = generateTeam(countInTeam, true);
        teamTwo = generateTeam(countInTeam, false);

        System.out.println("Team One Members:");
        for (Units units : teamOne) {
            System.out.println(units.name);
        }
        System.out.println("----------------");
        System.out.println("Team Two Members:");
        for (Units units : teamTwo) {
            System.out.println(units.name);
        }
        System.out.println("----------------");
        // вывод как бы поля 10х10
        // System.out.print("|");
        // for (Units units : teamOne) {
        // System.out.print(units.getName().charAt(0) + "|");
        // }

        // for (int i = 0; i < 8; i++) {
        // System.out.print("\n| | | | | | | | | | |");
        // }

        // System.out.println();
        // System.out.print("|");
        // for (Units units : teamTwo) {
        // System.out.print(units.getName().charAt(0) + "|");
        // }
        // Вотрая домашка
        teamOne.forEach(unit -> unit.step(teamTwo, teamOne));
    }

    private static int[] GetSortedIndex(ArrayList<Units> team, boolean direction) {
        int[] keys = new int[team.size()];
        for (int i = 0; i < team.size(); i++) {
            keys[i] = i;
        }

        boolean isSorted = false;
        while (!isSorted) {
            isSorted = true;
            for (int i = 0; i < keys.length - 1; i++) {
                if ((team.get(keys[i]).initiative > team.get(keys[i + 1]).initiative && direction)
                        || (team.get(keys[i]).initiative < team.get(keys[i + 1]).initiative && !direction)) {
                    isSorted = false;
                    int tmp = keys[i];
                    keys[i] = keys[i + 1];
                    keys[i + 1] = tmp;
                }
            }
        }
        return keys;
    }

    private static void PrintSortedInitiative(ArrayList<Units> team) {
        int[] keys = GetSortedIndex(team, true);
        for (int i = 0; i < team.size(); i++) {
            System.out.println(team.get(keys[i]).getInfo() + " Инициатива: " +
                    team.get(keys[i]).initiative);
        }
    }

    // Генератор команд
    private static ArrayList<Units> generateTeam(int countInTeam, boolean numOfTeam) {
        ArrayList<Units> team = new ArrayList<>();
        for (int i = 0; i < countInTeam; i++) {
            int ht = new Random().nextInt(4); // Можно поставить 3. чтобы точно не было крестьян для проверки
            if (numOfTeam)
                switch (ht) {
                    // Archer, Spearman, Shooter, Mage, Monk, Rogue, Peasant;
                    case 0:
                        team.add(new Archer(0, 15, 2, 4, 1, 10, i + 1, 1));
                        break;
                    case 1:
                        team.add(new Shooter(0, 20, 3, 5, 1, 10, i + 1, 1));
                        break;
                    case 2:
                        team.add(new Monk(0, 1, 25, i + 1, 1));
                        break;
                    case 3:
                        team.add(new Peasant(0, 1, 10, 10, 10, i + 1, 1));
                        break;
                }
            else
                switch (ht) {
                    case 0:
                        team.add(new Spearman(0, 15, 3, 4, 1, 10, i + 1, 10));
                        break;
                    case 1:
                        team.add(new Rogue(0, 10, 1, 3, 1, i + 1, 10));
                        break;
                    case 2:
                        team.add(new Mage(0, 5, 1, 2, 1, 100, i + 1, 10));
                        break;
                    case 3:
                        team.add(new Peasant(0, 1, 10, 10, 10, i + 1, 10));
                        break;
                }
        }
        return team;
    }

    public static void hw1() {
        Archer archerUnit = new Archer(0, 15, 2, 4, 1, 10, 1, 1);
        Shooter shooterUnit = new Shooter(0, 20, 3, 5, 1, 10, 1, 1);
        Spearman spearmanUnit = new Spearman(0, 15, 3, 4, 1, 10, 1, 1);
        Rogue rogueUnit = new Rogue(0, 10, 1, 3, 1, 1, 1);
        Mage mageUnit = new Mage(0, 5, 1, 2, 1, 100, 1, 1);
        Monk monkUnit = new Monk(0, 1, 25, 1, 1);
        Peasant peasantUnit = new Peasant(0, 1, 10, 10, 10, 1, 1);
        System.out.println(archerUnit.name + " " + archerUnit.healthPoints);
        System.out.println(shooterUnit.name + " " + shooterUnit.healthPoints);
        System.out.println(spearmanUnit.name + " " + spearmanUnit.healthPoints);
        System.out.println(rogueUnit.name + " " + rogueUnit.healthPoints);
        System.out.println(mageUnit.name + " " + mageUnit.healthPoints);
        System.out.println(monkUnit.name + " " + monkUnit.healthPoints);
        System.out.println(peasantUnit.name + " " + peasantUnit.healthPoints);
        System.out.println(archerUnit.getInfo());
        System.out.println(shooterUnit.getInfo());
        System.out.println(spearmanUnit.getInfo());
        System.out.println(rogueUnit.getInfo());
        System.out.println(mageUnit.getInfo());
        System.out.println(monkUnit.getInfo());
        System.out.println(peasantUnit.getInfo());
    }
}
