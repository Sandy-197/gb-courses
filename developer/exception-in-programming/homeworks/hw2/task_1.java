import java.util.Scanner;

public class task_1 {
    private static String encoding = System.getProperty("console.encoding", "UTF-8");
    private static Scanner scanner = new Scanner(System.in, encoding);

    public static void main(String[] args) {
        double result = GetDooble(
                "Введите дробное число, для отеделения дробной части используйте точку, пример (2.52): ");
        System.out.println("Спасибо. Вы ввели: " + result);
    }

    public static double GetDooble(String text) {
        double result;
        while (true) {
            System.out.print(text);
            try {
                result = Double.parseDouble(scanner.nextLine());
                return result;
            } catch (NumberFormatException e) {
                System.out.println("Ошибка!\nВы ввели не дробное число! Повтоорите ввод.");
            }
        }
    }
}
