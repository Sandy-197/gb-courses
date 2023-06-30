// Реализуйте структуру телефонной книги с помощью HashMap.
// Программа также должна учитывать, 
// что во входной структуре будут повторяющиеся имена с разными телефонами, 
// их необходимо считать, как одного человека с разными телефонами. 
// Вывод должен быть отсортирован по убыванию числа телефонов.

import java.lang.ref.PhantomReference;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Scanner;

public class hw5 {
    public static void main(String[] args) {
        HashMap<String, ArrayList<String>> phoneBook = GetPhoneBook(10);
        System.out.println(phoneBook);
    }

    public static HashMap<String, ArrayList<String>> GetPhoneBook(int count) {
        Scanner scanner = new Scanner(System.in);
        HashMap<String, ArrayList<String>> phoneBook = new HashMap<>();
        for (int i = 0; i < count; i++) {
            String name = scanner.nextLine();
            String phone = scanner.nextLine();
            if (phoneBook.containsKey(name)) {
                phoneBook.put(name, phoneBook.get(name).add(phone));
            } else {
                phoneBook.put(name, new ArrayList<>().add(phone));
            }
        }
        scanner.close();
        return phoneBook;
    }
}
