
import java.util.ArrayList;
import java.util.Random;

public class Program {
    public static void main(String[] args) {
        // hw1(); // Домашка 1
        hw2(); // Домашка 2
    }

    public static void hw2() {

        int countInTeam = 10; // Кол-во персонажей в команде
        ArrayList<Units> teamOne = generateTeam(countInTeam);
        ArrayList<Units> teamTwo = generateTeam(countInTeam);
        
        System.out.println("Team One Members:");
        for (Units units : teamOne) {
            System.out.println(units.getInfo());
        }
        System.out.println("----------------");
        System.out.println("Team Two Members:");
        for (Units units : teamTwo) {
            System.out.println(units.getInfo());
        }

        System.out.println("Team One Members Name Only:");
        for (Units units : teamOne) {
            System.out.println(units.getName());
        }
        System.out.println("----------------");
        System.out.println("Team Two Members Name Only:");
        for (Units units : teamTwo) {
            System.out.println(units.getName());
        }
    }

    // Генератор команд 
    private static ArrayList<Units> generateTeam(int countInTeam) {
        ArrayList<Units> team = new ArrayList<>();
        for (int i = 0; i < countInTeam; i++) {
            HeroTypes ht = HeroTypes.values()[new Random().nextInt(HeroTypes.values().length)];
            switch (ht) {
                case Archer:
                    team.add(new Archer(50, 15, 2, 4, 1, 10));
                    break;
                case Shooter:
                    team.add(new Shooter(100, 20, 3, 5, 1, 10));
                    break;
                case Spearman:
                    team.add(new Spearman(25, 15, 3, 4, 1, 10));
                    break;
                case Rogue:
                    team.add(new Rogue(25, 10, 1, 3, 1));
                    break;
                case Mage:
                    team.add(new Mage(0, 5, 1, 2, 1, 100));
                    break;
                case Monk:
                    team.add(new Monk(0, 1, 25));
                    break;
                case Peasant:
                    team.add(new Peasant(0, 1, 10, 10, 10));
                    break;
            }
        }
        return team;
    }

    public static void hw1() {
        Archer archerUnit = new Archer(50, 15, 2, 4, 1, 10);
        Shooter shooterUnit = new Shooter(100, 20, 3, 5, 1, 10);
        Spearman spearmanUnit = new Spearman(25, 15, 3, 4, 1, 10);
        Rogue rogueUnit = new Rogue(25, 10, 1, 3, 1);
        Mage mageUnit = new Mage(0, 5, 1, 2, 1, 100);
        Monk monkUnit = new Monk(0, 1, 25);
        Peasant peasantUnit = new Peasant(0, 1, 10, 10, 10);
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
