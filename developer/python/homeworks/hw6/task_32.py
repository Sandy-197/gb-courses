# Задача 32:
# Определить индексы элементов массива (списка),
# значения которых принадлежат заданному диапазону
# (т.е. не меньше заданного минимума и не больше заданного максимума)

import random
n = random.randint(10, 20)

lst = [random.randint(-20, 20) for _ in range(n)]
print(lst)
min_el = int(input("Введите минимальное значение: "))
max_el = int(input("Введите максимальное значение: "))
print(min_el, max_el)
for i in range(len(lst)):
    if min_el <= lst[i] <= max_el:
        print(i, end=" ")
