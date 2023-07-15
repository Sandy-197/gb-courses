package homework_5;
// Реализуйте структуру телефонной книги с помощью HashMap.

// Программа также должна учитывать, 
// что во входной структуре будут повторяющиеся имена с разными телефонами, 
// их необходимо считать, как одного человека с разными телефонами. 
// Вывод должен быть отсортирован по убыванию числа телефонов.

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import java.util.Scanner;

public class homework_5 {
    public static HashMap<String, ArrayList<String>> phoneBook = new HashMap<>();
    public static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        HashMap<String, ArrayList<String>> phoneFind;

        while (true) {
            System.out.println("Команды: ");
            System.out.println("1 - Добавить запись");
            System.out.println("2 - Найти запись");
            System.out.println("3 - Показать всю книгу");
            System.out.println("0 - Выход");
            System.out.print("Ваша команда: ");
            String key = scanner.nextLine();

            switch (key) {
                case "1":
                    AddPBRecord();
                    break;
                case "2":
                    phoneFind = GetPBRecord();
                    if (phoneFind != null)
                        PrintPB(phoneFind);
                    else
                        System.out.println("Запись не найдена!");
                    break;
                case "3":
                    PrintPB(phoneBook);
                    break;

                default:
                    scanner.close();
                    return;
            }
        }
    }

    public static boolean AddPBRecord() {

        System.out.println("Вводите имена и телефоны");

        System.out.print("Введите имя: ");
        String name = scanner.nextLine();
        if (name.equals(""))
            return false;
        System.out.print("Введите телефон: ");
        String phone = scanner.nextLine();
        ArrayList<String> tmp = new ArrayList<>();
        if (phoneBook.containsKey(name)) {
            tmp = phoneBook.get(name);
        }
        tmp.add(phone);
        phoneBook.put(name, tmp);
        return true;
    }

    public static HashMap<String, ArrayList<String>> GetPBRecord() {
        HashMap<String, ArrayList<String>> result = new HashMap<>();
        System.out.print("Введите имя для поиска: ");
        String name = scanner.nextLine();
        if (name.equals(""))
            return null;
        if (phoneBook.containsKey(name))
            result.put(name, phoneBook.get(name));
        else
            result = null;
        return result;
    }

    public static void PrintPB(HashMap<String, ArrayList<String>> pb) {
        ArrayList<String> keys = new ArrayList<>();
        pb.keySet().forEach(v -> keys.add(v));
        // Добавлена сортировка было на другом уроке не стал убирать, в приницпе здесь не нужна
        Collections.sort(keys, (o1, o2) -> phoneBook.get(o2).size() - phoneBook.get(o1).size());
        System.out.println("====================");
        System.out.println("Фамилия : Телефоны");
        keys.forEach(v -> System.out.println(v + " : " + pb.get(v)));
        System.out.println("====================");
    }
}
