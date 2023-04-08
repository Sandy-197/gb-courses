# Задание 7.
# Создать вручную и заполнить несколькими строками текстовый файл,
# в котором каждая строка будет содержать
# данные о фирме: название, форма собственности, выручка, издержки.
# Пример строки файла: firm_1 ООО 10000 5000.
#
# Необходимо построчно прочитать файл,
# вычислить прибыль каждой компании, а также среднюю прибыль.
# Если фирма получила убытки, в расчёт средней прибыли её не включать.
# Далее реализовать список.
# Он должен содержать словарь с фирмами и их прибылями,
# а также словарь со средней прибылью.
# Если фирма получила убытки, также добавить её в словарь (со значением убытков).
# !Значения убытков занесены отрицательным числом, иначе потом нельзя будет понять какая фирма в прибыли, а какая нет!
# Пример списка: [{“firm_1”: 5000, “firm_2”: 3000, “firm_3”: 1000}, {“average_profit”: 2000}].
#
# Итоговый список сохранить в виде json-объекта в соответствующий файл.
# Пример json-объекта:
# [{"firm_1": 5000, "firm_2": 3000, "firm_3": 1000}, {"average_profit": 2000}]
# Подсказка: использовать менеджер контекста.


from functools import reduce
import json

firm_list = []
firm_dict = {}
avr = []
with open('task_07-in.txt', 'r', encoding='UTF-8') as f_in:
	for st in f_in:
		s_list = list(map(lambda x: int(x) if x.isdigit() else x, st.split()))
		if s_list[2] > s_list[3]:
			avr.append(s_list[2] - s_list[3])
		firm_dict.setdefault(s_list[0], s_list[2] - s_list[3])

firm_list.append(firm_dict)
firm_list.append({"average_profit": reduce(lambda x, y: x + y, avr) / len(avr)})
# если средний профит раскидывать на все фирмы тогда запись будет такая:
# firm_list.append({"average_profit": reduce(lambda x, y: x + y, avr) / len(firm_dict)})

print(firm_list)
with open('task_07-out.json', 'w', encoding='UTF-8') as f_out:
	json.dump(firm_list, f_out, ensure_ascii=False, indent=4)
