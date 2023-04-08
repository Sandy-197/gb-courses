# Задание 2.
# Создать текстовый файл (не программно),
# сохранить в нём несколько строк,
# выполнить подсчёт строк и слов в каждой строке.

r = 0
w = 0
w_all = 0

with open('task_02.txt', 'r', encoding='UTF-8') as f_obj:
	while True:
		st = f_obj.readline()
		if st == '':
			break
		r += 1
		w = len(st.split())
		w_all+=w
		print(f'"{st[:-1]}" --- В строке {r} - {w} слов.')

print(f'Всего строк: {r}\nВсего слов: {w_all}')
