# Задание 1.
# Реализовать скрипт, в котором должна быть предусмотрена функция расчёта
# заработной платы сотрудника. Используйте в нём формулу:
# (выработка в часах*ставка в час) + премия.
# Во время выполнения расчёта для конкретных значений необходимо запускать скрипт с параметрами.

from sys import argv


def get_salary(h, stavka, bonus):
	return round(h * stavka + bonus, 2)


try:
	scr_name, work_hours, stavka, bonus = argv
	work_hours = int(work_hours)
	stavka = float(stavka)
	bonus = float(bonus)
except ValueError:
	print(
		f'Ошибка ввода данных!\nЗапуск через "python task-1.py Рабочие_часы(целые), Ставка_в_час(дробное), Бонус"(дробное)"')
	exit()

print(get_salary(work_hours, stavka, bonus))  # функция
print((lambda v_1, v_2, v_3: v_1 * v_2 + v_3)(work_hours, stavka, bonus))  # lambda
