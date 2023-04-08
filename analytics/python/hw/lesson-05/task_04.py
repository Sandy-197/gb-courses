# Задание 4.
# Создать (не программно) текстовый файл со следующим содержимым:
# One — 1
# Two — 2
# Three — 3
# Four — 4
# Напишите программу, открывающую файл на чтение и считывающую построчно данные.
# При этом английские числительные должны заменяться на русские.
# Новый блок строк должен записываться в новый текстовый файл.
# Используются модуль translate https://translate-python.readthedocs.io/en/latest/index.html
# Установка pip install translate

from translate import Translator

trans = Translator(from_lang='en', to_lang="ru")

with open('task_04-in.txt', 'r', encoding='UTF-8') as f_in:
	with open('task_04-out.txt', 'w', encoding='UTF-8') as f_out:
		for st in f_in:
			w = st.split()[0]
			f_out.write(st.replace(w, trans.translate(w)))
