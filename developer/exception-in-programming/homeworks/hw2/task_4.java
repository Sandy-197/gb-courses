import java.util.Scanner;

public class task_4 {
    public static void main(String[] args) throws Exception {

        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите строку: ");
        String myStr = scanner.nextLine();
        scanner.close();
        if (myStr == null || myStr == "")
            throw new Exception("Нельзя вводить пустую строку!");
        else
            System.out.println(myStr);
    }
}
