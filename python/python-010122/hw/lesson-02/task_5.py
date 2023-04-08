# 5. Задание
# Реализовать структуру «Рейтинг», представляющую собой набор натуральных чисел, который не возрастает.
# У пользователя нужно запрашивать новый элемент рейтинга.
# Если в рейтинге существуют элементы с одинаковыми значениями,
# то новый элемент с тем же значением должен разместиться после них.
#
# Подсказка. Например, набор натуральных чисел: 7, 5, 3, 3, 2.
# Пользователь ввёл число 3. Результат: 7, 5, 3, 3, 3, 2.
# Пользователь ввёл число 8. Результат: 8, 7, 5, 3, 3, 2.
# Пользователь ввёл число 1. Результат: 7, 5, 3, 3, 2, 1.

# Набор натуральных чисел можно задать сразу в коде, например, my_list = [7, 5, 3, 3, 2].

my_list = [7, 5, 3, 3, 2]

while True:
    element = input('Новый элемент рейтинга в виде натурального числа: ')
    if element.isdecimal() and int(element) > 0:
        element = int(element)
        break
    else:
        print('Ошибка! Введите натуральное число.')

# 1. Вариант

print(f'Исходный список\n{my_list}')

my_list.append(element)
my_list.sort(reverse=True)

print(f'Финальный список\n{my_list}')

# 2. Вариант

my_list = [7, 5, 3, 3, 2]

if element in my_list:
    my_list.insert(my_list.index(element) + my_list.count(element), element)
else:
    el = my_list[0]
    i = 1
    while el >= element and i < len(my_list):
        el = my_list[i]
        i += 1
    if len(my_list) == i:
        my_list.append(element)
    else:
        my_list.insert(i - 1, element)

print(my_list)
