# Задача 16:
# Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai.
# Последняя строка содержит число X
# *Пример:*
# 5
# 1 2 3 4 5
# 3
# -> 1

# Задача 18:
# Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X.
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих строках записаны N целых чисел Ai.
# Последняя строка содержит число X
# *Пример:*
# 5
#     1 2 3 4 5
#     6
#     -> 5

import random
count_items = int(input("Введите кол-во элементов списка: "))
lst = [random.randint(1, count_items) for _ in range(count_items)]
print(f"Наш список:\n{lst}")

item_to_find = int(
    input("Введите элемент списка, который хотите найти и посчитать: "))

# 16 задача: можно решить так:
count_found = lst.count(item_to_find)
print(f"Найдено: {count_found} элементов.") if count_found > 0 else print(
    f"числа {item_to_find} нет в списке.")

# 16 + 18 задачи: решение циклами:
# для 16 подсчет элементов без метода list.count()
# для 18 задачи ищим все ближайшие

count_found = 0
min_item = list()
min_diff = abs(lst[0]-item_to_find)

for item in lst:
    if item == item_to_find:
        count_found += 1
        min_item.clear()
    elif count_found == 0:
        if min_diff == abs(item-item_to_find):
            min_item.append(item)
        elif min_diff > abs(item-item_to_find):
            min_diff = abs(item-item_to_find)
            min_item.clear()
            min_item.append(item)

if count_found == 0:
    print(f"Элемент {item_to_find} не найден. Ближайшие {min_item}")
else:
    print(f"Кол-во элементов {item_to_find} равно {count_found}")
