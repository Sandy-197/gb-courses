// package homework_6;
// Разработать программу, имитирующую поведение коллекции HashSet. 

// В программе содать метод add добавляющий элемент, 
// метод toString возвращающий строку с элементами множества и метод позволяющий читать элементы по индексу.
// *Реализовать все методы из семинара.

import java.lang.management.OperatingSystemMXBean;
import java.util.*;

public class homework_6 {

    public static class Cat {
        String color; // Окрас
        String breed; // Порода
        boolean hasTail = true; // Купирован ли хвост
        boolean sex; // Пол
        String name; // Кличка
        int age;

        public Cat(String name, String color, String bread, boolean hasTail, boolean sex, int age) {
            this.name = name;
            this.color = color;
            this.breed = bread;
            this.hasTail = hasTail;
            this.sex = sex;
            if (age >= 0)
                this.age = age;
            else
                this.age = 0;
        }

        public String toString() {
            return "Кличка: " + this.name + ", цвет: " + this.color + ", порода: " + this.breed
                    + ((this.hasTail) ? ", хвост есть" : ", хвоста нет")
                    + ((this.sex) ? ", пол мужской" : ", пол женский") + ".";
        }

        // Приватный метод, собираем в кучу все параметры, чтобы не преепрописывать в
        // equals каждый отдельно.
        private String forEquals() {
            return this.name + this.color + this.breed + this.hasTail + this.sex + this.age;
        }

        @Override
        public boolean equals(Object o) {
            // Проверяем не передан ли тот же самый объект
            if (this == o)
                return true;
            // Проверяем что не передан несуществующий объект
            if (o == null)
                return false;
            // Проверяем, что класс переданного объекта соответсвует нашему и мы можем
            // сравнивать
            if (this.getClass() != o.getClass())
                return false;
            // Приводим класс Object o к классу Cat
            Cat temp = (Cat) o;
            return Objects.equals(this.forEquals(), temp.forEquals());
        }

        @Override
        public int hashCode() {
            return Objects.hash(this.name, this.color, this.breed, this.hasTail, this.sex, this.age);
        }

    }

    public static void main(String[] Args) {

        HashSet<Cat> catsSet = new HashSet<>();
        Cat cat = new Cat("Барсик", "black", "Сиамский", true, true, 3);
        Cat cat2 = new Cat("Барсик", "black", "Сиамский", true, true, 3); // дубль cat
        Cat cat3 = new Cat("Милашка", "white", "Сиамский", true, false, 4);

        System.out.println("Выводим всех котов из объектоов.");
        System.out.println(cat.toString());
        System.out.println(cat2.toString());
        System.out.println(cat3.toString());

        System.out.println(
                "Добавляем всех котов в HashSet.\nПечатаем резулььтат добавления. дубль сраузу не добавиться.");
        System.out.println("Добавляем кота:" + cat.toString() + " Результат: "
                + (catsSet.add(cat) ? "Добавлен." : " Не добавлен."));
        System.out.println("Добавляем кота:" + cat2.toString() + " Результат: "
                + (catsSet.add(cat2) ? "Добавлен." : " Не добавлен."));
        System.out.println("Добавляем кота:" + cat3.toString() + " Результат: "
                + (catsSet.add(cat3) ? "Добавлен." : " Не добавлен."));

        System.out.println("Выводим добавленных в Hashmap котов:");
        for (Cat catTemp : catsSet) {
            System.out.println(catTemp.toString());
        }

        System.out.println("Выводим hashCode для котов:");
        System.out.println(cat.name + "-" + cat.hashCode());
        System.out.println(cat2.name + "-" + cat2.hashCode());
        System.out.println(cat3.name + "-" + cat3.hashCode());

        System.out.println("Выводим проверку равенства котов:");
        System.out.println("Первый кот равен второму? - " + (cat.equals(cat2) ? "Да" : "Нет"));
        System.out.println("Первый кот равен третьему? - " + (cat.equals(cat3) ? "Да" : "Нет"));

    }
}
