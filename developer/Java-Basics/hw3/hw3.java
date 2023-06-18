import java.util.ArrayList;
import java.util.Comparator;
import java.util.Random;
// Задание

// Пусть дан произвольный список целых чисел.

// 1) Нужно удалить из него чётные числа
// 2) Найти минимальное значение
// 3) Найти максимальное значение
// 4) Найти среднее значение
public class hw3 {
    public static void main(String[] args) {
        int count = 10;
        int max = 15;

        ArrayList<Integer> list = GenerateRandomArrayList(count, max);
        System.out.println(list.toString());
        RemoveEven(list);                       //Удаляем чётные
        System.out.println("list without even="+list.toString());
        System.out.println("max="+MaxInList(list));    // Максимальный элемент
        System.out.println("min="+MinInList(list));    // Минимальный элемент
        System.out.println("mean="+MeanInList(list));   // Среднее значение
    }

    public static ArrayList<Integer> GenerateRandomArrayList(int count, int max) {
        ArrayList<Integer> list = new ArrayList<>();
        for (int i = 0; i < count; i++) {
            list.add(new Random().nextInt(max));
        }
        return list;
    }

    public static void RemoveEven(ArrayList<Integer> list) {
        list.removeIf((e -> (e % 2) == 0));
    }

    public static int MaxInList(ArrayList<Integer> list) {
        // list.sort(new Comparator<Integer>() {
        //     @Override
        //     public int compare(Integer o1, Integer o2) {
        //         return o2-o1;
        //     }
        // });
        list.sort(Comparator.reverseOrder());
        return list.get(0);
    }

    public static int MinInList(ArrayList<Integer> list) {
        // list.sort(new Comparator<Integer>() {
        //     @Override
        //     public int compare(Integer o1, Integer o2) {
        //         return o1 - o2;
        //     }
        // });
        list.sort(Comparator.naturalOrder());
        return list.get(0);
    }

    public static double MeanInList(ArrayList<Integer> list) {
        int sum = 0;
        for (Integer elInteger : list) {
            sum+=elInteger;
        }
        return (double) sum/(double) list.size();
    }

}