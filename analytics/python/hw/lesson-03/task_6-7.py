# Задание 6.
# Реализовать функцию int_func(), принимающую слова из маленьких латинских букв и возвращающую их же,
# но с прописной первой буквой.
# Например, print(int_func(‘text’)) -> Text.
# Задание 7.
# Продолжить работу над заданием 6.
# В программу должна попадать строка из слов, разделённых пробелом.
# Каждое слово состоит из латинских букв в нижнем регистре.
# Нужно сделать вывод исходной строки, но каждое слово должно начинаться с заглавной буквы.
# Используйте написанную ранее функцию int_func().

def remove_nonalfa_chr(var):
    """ переводит строку в нижний регистр,
        удаляет все символы, кроме символов латинского алфавита

        аргумент:
        var -- строка
    """
    var = str(var).lower()
    res = ''
    for ch in var:
        if 'a' <= ch <= 'z' or ch == ' ':
            res += ch
    return res


def int_func(var):
    """ Получает слово из маленьких латинских букв.
        Проверяет на валидность.
        Возвращает слово с первой заглавной буквы

        аргументы:
        var: слово из маленьких латинских букв
    """
    var = str(var)

    if not var.isalpha():
        return None

    var = var.split()[0].lower()
    i = 0

    for ch in var:
        if 'a' <= ch <= 'z':
            i += 1
        else:
            break
    return var.title() if i == len(var) else ''


my_str = (input('Введите несколько слов на английском языке разделенные пробелом: ')).split()
if len(my_str) == 0:
    exit()

# Вариант 1. сбор строки через список

my_new_str = []
for word in my_str:
    if word.isalpha():
        my_new_str.append(int_func(word))

print(' '.join(my_new_str))

# Вариант 2. сбор строки объединением

my_new_str = ''
for word in my_str:
    if word.isalpha():
        my_new_str += ' ' + int_func(word)

print(my_new_str[1:len(my_new_str)])

# Вариант 3. сбор строки через список с применением функции удаления из строк всех не латинских букв

my_new_str = []
print(my_str)
for word in my_str:
    word = remove_nonalfa_chr(word)
    print(word)
    if word is not None and word != '':
        my_new_str.append(int_func(word))

print(my_new_str)
print(' '.join(my_new_str))
