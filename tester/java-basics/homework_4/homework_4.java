package homework_4;

import java.util.Arrays;
import java.util.LinkedList;
import java.util.Scanner;
// 1. Пусть дан LinkedList с несколькими элементами. Реализуйте метод, который вернет “перевернутый” список.
// 2 *. Реализуйте очередь с помощью LinkedList со следующими методами:
// enqueue() - помещает элемент в конец очереди,
// dequeue() - возвращает первый элемент из очереди и удаляет его,
// first() - возвращает первый элемент из очереди, не удаляя.
// Это задание повышенной сложности, для решения задачи потребуется создать класс-обертку над LinkedList, например:
// class MyQueue {
//     private LinkedList elements = new LinkedList();
//     public MyQueue() { }
//     public MyQueue(LinkedList linkedList) {
//         this.elements = linkedList;
//     }
//         .........
// }
// 3. В калькулятор (урок 1 и 2) добавьте возможность отменить последнюю операцию.


public class homework_4 {
    // Существет проблема в VSCode с русскими символами в Scanner
    static String encoding = System.getProperty("console.encoding", "UTF-8");
    static Scanner scanner = new Scanner(System.in, encoding);

    public static void main(String[] args) {
        task_1();
        task_3();
    }

    public static void task_1() {
        LinkedList<Integer> ll = new LinkedList<>(Arrays.asList(1, 2, 3, 4, 5));
        System.out.println(ll);
        LinkedList<Integer> ll_reverse = reverseLinkedList(ll);
        System.out.println(ll_reverse);
    }

    private static LinkedList<Integer> reverseLinkedList(LinkedList<Integer> ll) {
        LinkedList<Integer> result = new LinkedList<>();
        for (int i = ll.size() - 1; i >= 0; i--) {
            result.add(ll.get(i));
        }
        return result;
    }

    public static void task_3() {
        calc();
    }

    // Simple Calculator
    // Не делаем проверок на не корректные значения.
    // Считаем, что все введено верно.
    public static void calc() {
        String allow_deistvie = "*/-+<0"; // Возможные действия нашего калькулятора
        System.out.println("Калькулятор.");
        System.out.println("При выборе действия:");
        System.out.println("Нажмите '0', чтобы выйти из калькулятора");
        System.out.println("Нажмите '<', чтобы отменить последнюю операцию");
        System.out.println("Нажмите '+ - / *', для выбора арифметической операции.");
        LinkedList<Double> results = new LinkedList<>();

        while (true) {
            // запрос первого числа, если небыло еще действий
            double a = (results.size() > 0) ? results.getLast()
                    : Double.parseDouble(inputData(scanner, "Введите первое число"));

            // Проверка, что введены разрешенные действия
            String deistvie = "";
            boolean cicle = true;
            while (cicle) {
                deistvie = inputData(scanner, "Введите действие");
                cicle = !(allow_deistvie.contains(deistvie));
                if (cicle)
                    System.out.println("Действия могут быть только '+ - / * < 0'\nПовторите ввод.");
            }

            if (deistvie.equals("0"))
                break;
            if (deistvie.equals("<")) {
                if (results.size() > 0)
                    results.removeLast();
                if (results.size() > 0)
                    System.out.println("Результат: " + results.getLast());
                continue;
            }

            // Проверяем, если результатов пока не было, то ставим результатом первое число
            if (results.size() == 0)
                results.add(a);

            // Проверка, если действие деление и второе число введено 0, то запрос ввод
            // нового числа.
            cicle = true;
            double b = 0;
            while (cicle) {
                b = Double.parseDouble(inputData(scanner, "Введите второе число"));
                cicle = ((b == 0) & (deistvie.contains("/")));
                if (cicle)
                    System.out.println("Делить на ноль нельзя.\nПовторите ввод второго числа.");
            }

            results.add(Calculate(a, b, deistvie));
            System.out.println("Результат: " + results.getLast());
        }
    }

    // Simple Calculator
    private static double Calculate(double a, double b, String deistvie) {
        double result = 0;
        switch (deistvie) {
            case "*":
                result = a * b;
                break;
            case "/":
                result = a / b; // проверка деления на ноль сделана на этаппе ввода чисел.
                break;
            case "+":
                result = a + b;
                break;
            case "-":
                result = a - b;
                break;
        }
        return result;
    }

    // Ввод данных с запросом 'text'
    public static String inputData(Scanner scanner, String text) {
        System.out.print(text + ": ");
        return scanner.nextLine();
    }
}