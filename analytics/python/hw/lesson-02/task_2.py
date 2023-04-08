# 2. Задание
# Для списка реализовать обмен значений соседних элементов.
# Значениями обмениваются элементы с индексами 0 и 1, 2 и 3 и т. д.
# При нечётном количестве элементов последний сохранить на своём месте.
# Для заполнения списка элементов нужно использовать функцию input().
#

my_list = []

print('Заполните свой список, по окончании ввода нажмите клавишу "Q":')

while True:
    element = input('Введите элемент списка: ')
    if element == 'Q':
        break
    my_list.append(element)

print(f'Ваш список:\n{my_list}')

count_el = len(my_list) // 2 * 2  # игнорируем последний элемент списка, если кол-во элементов нечетное
i = 0
while i < count_el:
    # element = my_list[i]
    # my_list[i] = my_list[i + 1]
    # my_list[i + 1] = element
    my_list[i], my_list[i + 1] = my_list[i + 1], my_list[i]
    i += 2

print(f'Результирующий список:\n{my_list}')

i = 0
while i < count_el:
    my_list[i], my_list[i + 1] = my_list[i + 1], my_list[i]
    i += 2

print(my_list)
