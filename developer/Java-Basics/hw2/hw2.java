// Задание

// Дана строка sql-запроса "select * from students where ". Сформируйте часть WHERE этого запроса, используя StringBuilder. Данные для фильтрации приведены ниже в виде json-строки.
// Если значение null, то параметр не должен попадать в запрос.
// Параметры для фильтрации: {"name":"Ivanov", "country":"Russia", "city":"Moscow", "age":"null"}
// В итоге должно получится select * from students where name=Ivanov, country=Russia, city=Moscow

// Дополнительные задания

// Дана json-строка (можно сохранить в файл и читать из файла)
// [{"фамилия":"Иванов","оценка":"5","предмет":"Математика"},{"фамилия":"Петрова","оценка":"4","предмет":"Информатика"},{"фамилия":"Краснов","оценка":"5","предмет":"Физика"}]
// Написать метод(ы), который распарсит json и, используя StringBuilder, создаст строки вида: Студент [фамилия] получил [оценка] по предмету [предмет].
// Пример вывода:
// Студент Иванов получил 5 по предмету Математика.
// Студент Петрова получил 4 по предмету Информатика.
// Студент Краснов получил 5 по предмету Физика.

// *Сравнить время выполнения замены символа "а" на "А" любой строки содержащей >1000 символов средствами String и StringBuilder.
public class hw2 {
    public static void main(String[] args) {
        String sqlQueryStr = "select * from students";
        String jsonString = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"}";
        String jsonStringTask2 = "[{\"фамилия\":\"Иванов\",\"оценка\":\"5\",\"предмет\":\"Математика\"},{\"фамилия\":\"Петрова\",\"оценка\":\"4\",\"предмет\":\"Информатика\"},{\"фамилия\":\"Краснов\",\"оценка\":\"5\",\"предмет\":\"Физика\"}]";

        System.out.println(GetSelectString(sqlQueryStr, jsonString));
        // Вариант 1. Массив строк
        System.out.println(String.join("\n", ParseString(jsonStringTask2)));
        // Вариант 2. Строка StringBuilder со всеми данными
        System.out.println(ParseString2(jsonStringTask2));
    }

    // 1 Задача парсер одной строки
    public static String GetSelectString(String sqlQueryStr, String jsonString) {
        String whereString = "";
        String[] wstring = jsonString.strip().replace("{", "").replaceAll("}", "").replaceAll("\"", "")
                .replaceAll(" ", "").replaceAll(":", "=").split(",");
        for (String str : wstring) {
            if (!str.split("=")[1].equals("null")) {
                whereString += str + ", ";
            }
        }
        if (whereString.length() > 0)
            whereString = " where " + whereString;
        return sqlQueryStr + whereString.substring(0, whereString.length() - 2);
    }
    // 2 Задача парсер json,
    // Вариант 1. возвращаем массив собранных строк

    public static String[] ParseString(String jsonString) {

        String[] tempStrings = jsonString.strip().substring(2, jsonString.length() - 2).replace("},{", ";")
                .replace("\"", "").split(";");
        String[] wordStrings = { "Студент ", " получил ", " по предмету " };
        StringBuilder result = new StringBuilder();
        String[] res = new String[tempStrings.length];
        int j = 0;
        for (String string : tempStrings) {
            int i = 0;
            for (String string2 : string.split(",")) {
                result.append(wordStrings[i++]);
                result.append(string2.split(":")[1]);
            }
            res[j++] = result.toString();
            result.setLength(0);
        }
        return res;
    }

    // 2 Задача парсер json,
    // Вариант 1. возвращаем массив собранных строк
    public static StringBuilder ParseString2(String jsonString) {

        String[] tempStrings = jsonString.strip().substring(2, jsonString.length() - 2).replace("},{", ";")
                .replace("\"", "").split(";");
        String[] wordStrings = { "Студент ", " получил ", " по предмету " };
        StringBuilder result = new StringBuilder();

        for (String string : tempStrings) {
            int i = 0;
            for (String string2 : string.split(",")) {
                result.append(wordStrings[i++]);
                result.append(string2.split(":")[1]);
            }
            result.append("\n");
        }
        return result;
    }
}
