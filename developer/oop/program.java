public class program {
    public static void main(String[] args) {
        archer archerUnit = new archer(50, 15, 2, 4, 1, 10);
        shooter shooterUnit = new shooter(100, 20, 3, 5, 1, 10);
        spearman spearmanUnit = new spearman(25, 15, 3, 4, 1, 10);
        rogue rogueUnit = new rogue(25, 10, 1, 3, 1);
        mage mageUnit = new mage(0, 5, 1, 2, 1, 100);
        monk monkUnit = new monk(0, 1, 25);
        peasant peasantUnit = new peasant(0, 1, 10, 10, 10);
        System.out.println(archerUnit.name + " " + archerUnit.healthPoints);
        System.out.println(shooterUnit.name + " " + shooterUnit.healthPoints);
        System.out.println(spearmanUnit.name + " " + spearmanUnit.healthPoints);
        System.out.println(rogueUnit.name + " " + rogueUnit.healthPoints);
        System.out.println(mageUnit.name + " " + mageUnit.healthPoints);
        System.out.println(monkUnit.name + " " + monkUnit.healthPoints);
        System.out.println(peasantUnit.name + " " + peasantUnit.healthPoints);
    }
}
