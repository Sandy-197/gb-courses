# Задание 5.
# Создать (программно) текстовый файл, записать в него программно набор чисел, разделённых пробелами.
# Программа должна подсчитывать сумму чисел в файле и выводить её на экран.

from random import randint
from functools import reduce

d_count = 10  # кол-во сгенерированных целых чисел
max_random = 100 # максимальная цифра для генератора

# 1 вариант записи числе. генерация и сразу запись. из минусов получаем лишний пробел в конце файла
with open('task_05.txt', 'w', encoding='UTF-8') as f_out:
	for _ in range(d_count):
		f_out.write(str(randint(1, max_random)) + ' ')

# 2 вариант. генерация чисел в список и запись его в файл, более предпочтительный
my_list = [str(randint(1, max_random)) for _ in range(d_count)]
with open('task_05.txt', 'w', encoding='UTF-8') as f_out:
	f_out.write(' '.join(my_list))

s = 0
with open('task_05.txt', 'r', encoding='UTF-8') as f_in:
	st = f_in.readline()
	s += reduce(lambda x, y: x + y, map(int, st.split()))

print(f'{"+".join(st.split())}={s}')

with open('task_05.txt', mode='r', encoding='utf-8') as f_in:
	print(sum(map(int, f_in.readline().split())))
