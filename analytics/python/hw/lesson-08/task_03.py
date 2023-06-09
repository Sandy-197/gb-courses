# Задание 3.
# Создайте собственный класс-исключение, который должен проверять содержимое списка на наличие только чисел.
# Проверить работу исключения на реальном примере.
# Запрашивать у пользователя данные и заполнять список необходимо только числами.
# Класс-исключение должен контролировать типы данных элементов списка.
# Примечание: длина списка не фиксирована.
# Элементы запрашиваются бесконечно, пока пользователь сам не остановит работу скрипта, введя, например, команду «stop».
# При этом скрипт завершается, сформированный список с числами выводится на экран.
# Подсказка: для этого задания примем, что пользователь может вводить только числа и строки.
# Во время ввода пользователем очередного элемента необходимо реализовать проверку типа элемента.
# Вносить его в список, только если введено число.
# Класс-исключение должен не позволить пользователю ввести текст (не число) и отобразить соответствующее сообщение.
# При этом работа скрипта не должна завершаться.

class OnError(Exception):
	def __init__(self, txt):
		self.txt = txt


my_list = []
print(
	"Вводите значения для списка, только числа.\n"
	"Числа могут быть любыми вещественными\nЧтобы закончить ввод введите 'q'")

while True:
	digit = input(f'Введите{" следующее " if len(my_list)!=0 else " "}число для добавления в список:')
	try:
		digit = digit.replace(',', '.')
		if digit in "qQйЙ":
			break
		if (digit.replace('.', '').isdigit()) and (digit.count('.') in [0, 1]):
			if digit.count('.') == 0:
				my_list.append(int(digit))
			else:
				my_list.append(float(digit))
		else:
			raise OnError("Вы ввели не число, повторите ввод")

	except OnError as err:
		print(err)

print(f'Ваш список:\n{my_list}')
