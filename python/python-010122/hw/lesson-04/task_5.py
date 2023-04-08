# Задание 5.
# Реализовать формирование списка, используя функцию range() и возможности генератора.
# В список должны войти чётные числа от 100 до 1000 (включая границы).
# Нужно получить результат вычисления произведения всех элементов списка.
# Подсказка: использовать функцию reduce().

from functools import reduce


def my_func(el1, el2):
	return el1 * el2


print(reduce(my_func, [el for el in range(100, 1001) if el % 2 == 0]))  # через функцию

print(reduce(lambda el1, el2: el1 * el2, [el for el in range(100, 1001) if el % 2 == 0]))  # через lambda
