package homework_1;

import java.util.Scanner;

public class homework_1 {
    // Существет проблема в VSCode с русскими символами в Scanner
    static String encoding = System.getProperty("console.encoding", "UTF-8");
    static Scanner scanner = new Scanner(System.in, encoding);

    public static void main(String[] args) {
        boolean cicle = true;
        System.out.println("Домашняя работа №1");

        while (cicle) {
            System.out.println("Выберете задание:");
            System.out.print("Нажмите 1 для 1 задания: ");
            System.out.println(
                    "Вычислить n-ое треугольного число (сумма чисел от 1 до n)\n\t\t\tn! (произведение чисел от 1 до n)");

            System.out.print("Нажмите 2 для 2 задания: ");
            System.out.println("Вывести все простые числа от 1 до 1000");

            System.out.print("Нажмите 3 для 3 задания: ");
            System.out.println("Простой калькулятор.\n\t\t\t4 Действия '* / + - '");

            System.out.print("Нажмите 0 для завершения работы программы.");

            String task = inputData(scanner, "Выберите номер задания");
            switch (task) {
                case "1":
                    task1();
                    break;
                case "2":
                    task2();
                    break;
                case "3":
                    task3();
                    break;
                case "0":
                    cicle = false;
                    break;
            }
            System.out.println("---------------------");
        }

        scanner.close();
    }

    // Задание 1.
    // Вычислить n-ое треугольного число (сумма чисел от 1 до n)
    // n! (произведение чисел от 1 до n)
    public static void task1() {

        int n = -1;
        // цикл будет запршивать ввод числа, пока не будет введено >=0;
        while (n < 0) {
            n = Integer.parseInt(inputData(scanner, "Введите n, большее или равное 0"));
        }
        // если введеное число равно нулю, то N-треугольного числа вычислить нельзя,
        // будет выведено соответсвеющее сообщение.
        if (n == 0) {
            System.out.println("N треугольного числа для N=0 не существует.");
        } else {
            System.out.println("N треугольное число для числа " + n + " равно = " + GetSumOfNatural(n));
        }
        System.out.println("Факториал для числа " + n + " равен = " + GetFactorial(n));
    }

    // Задание 2.
    // Вывести все простые числа от 1 до 1000
    public static void task2() {
        int n = -1;
        // цикл будет запршивать ввод числа, пока не будет введено > 0;
        while (n <= 0) {
            n = Integer.parseInt(inputData(scanner, "Введите n, больше 0"));
        }
        String res = GetSimpleNum(n);
        if (res.length() > 0) {
            System.out.println("Простые числа: " + res);
        } else {
            System.out.println("Не нашлось простых чисел.");
        }
        int[] resInt = ConvertStringToIntArray(res, " ");
        if (resInt.length > 0) {
            System.out.print("Простые числа: ");
            for (int i : resInt) {
                System.out.print(i + " ");
            }
        } else {
            System.out.println("Не нашлось простых чисел.");
        }
        System.out.println();
    }

    // Simple Calculator
    // Не делаем проверок на не корректные значения.
    // Считаем, что все введено верно.
    public static void task3() {
        String allow_deistvie = "*/-+"; // Возможные действия нашего калькулятора
        System.out.println("Калькулятор.");
        double a = Double.parseDouble(inputData(scanner, "Введите первое число"));
        String deistvie = "";

        // Проверка, что введены разрешенные действия
        boolean cicle = true;
        while (cicle) {
            deistvie = inputData(scanner, "Введите действие");
            cicle = !(allow_deistvie.contains(deistvie));
            if (cicle)
                System.out.println("Действия могут быть только '+ - / *'\nПовторите ввод.");
        }
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

        double result = Calculate(a, b, deistvie);
        System.out.println(a + deistvie + b + "=" + result);
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

    // метод вычисляющий сумму натуральных числе от 1 до N;
    // вернет -1, как ошибку, если n будет меньше или равно нулю.
    private static int GetSumOfNatural(int n) {
        if (n <= 0)
            return -1;
        int s = 1;
        for (int i = 2; i <= n; i++) {
            s += i;
        }
        return s;
    }

    // метод вычисляет факториал числа n от 0 до N;
    // вернет -1, если n находиться в неправильных пределах
    // дальше эту ошибку может обработать на более верхнем уровне
    private static int GetFactorial(int n) {
        if (n < 0)
            return -1;
        int f = 1;
        for (int i = 2; i <= n; i++) {
            f *= i;
        }
        return f;
    }

    // метод возвращает строку содержащую через пробел все простые числа от 1 до N;
    // вернет пустую строку, если n за пределами диапазона.
    // далее можно конвертитроать в массив Integer
    private static String GetSimpleNum(int n) {
        if (n <= 0)
            return "";

        String result = "";
        if (n > 0) {
            result = "1";
        }
        if (n > 1) {
            result += " " + "2";
        }
        for (int i = 3; i <= n; i += 2) {
            if (((i % 3 != 0) & (i % 5 != 0) & (i % 7 != 0)) | ((i == 3) | (i == 5) | (i == 7))) {
                result += " " + Integer.toString(i);
            }
        }
        return result;
    }

    // Конвертируем строку st с числами, разделенными sp
    // Возвращаем массив int
    // Проверка на валидность строки не делаем.
    // Есть варианты проще, но мы их еще не проходили
    private static int[] ConvertStringToIntArray(String st, String sp) {

        String[] numberSt = st.split(sp);
        int[] numbers = new int[numberSt.length];
        for (int i = 0; i < numberSt.length; i++) {
            numbers[i] = Integer.parseInt(numberSt[i]);
        }
        return numbers;
    }

    // Ввод данных с запросом 'text'
    public static String inputData(Scanner scanner, String text) {
        System.out.print(text + ": ");
        return scanner.nextLine();
    }
}
