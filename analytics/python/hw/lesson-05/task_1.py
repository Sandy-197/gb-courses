# Задание 1.
# Создать программный файл в текстовом формате,
# записать в него построчно данные,вводимые пользователем.
# Об окончании ввода данных будет свидетельствовать пустая строка.


with open("task_1.txt", 'w',encoding='UTF-8') as file_obj:
	while True:
		st = input('Введите строку для записи в файл.\nДля завершения ввода нажмите Enter на пустой строке: ')
		if st == '':
			break

		file_obj.write(st+'\n')
