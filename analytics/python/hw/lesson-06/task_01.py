# Задание 1.
# Создать класс TrafficLight (светофор).
# Определить у него один атрибут color (цвет) и метод running (запуск);
# атрибут реализовать как приватный;
# в рамках метода реализовать переключение светофора в режимы: красный, жёлтый, зелёный;
# продолжительность:
# первого состояния (красный) составляет 7 секунд,
# второго (жёлтый) — 2 секунды,
# третьего (зелёный) — на ваше усмотрение;
# переключение между режимами должно осуществляться только в указанном порядке (красный, жёлтый, зелёный);
# проверить работу примера, создав экземпляр и вызвав описанный метод.
# Задачу можно усложнить, реализовав проверку порядка режимов.
# При его нарушении выводить соответствующее сообщение и завершать скрипт.

from time import sleep


class TrafficLight:
	"""Класс TrafficLight"""

	def __init__(self, init_color='red', time_r=7, time_y=2, time_g=5):
		"""Конструктор класса TrafficLight\n
			:param init_color: Цвет с которого начинает работать светофор, по умолчанию красный
			:param time_r: Время которое горит красный сигнал. по умолчанию 7 секунд
			:param time_y: Время которое горит желтый сигнал. по умолчанию 2 секунды
			:param time_g: Время которое горит зеленый сигнал. по умолчанию 5 секунд
		"""

		self.__color = init_color
		self.__index_of_color = 0
		self.__list_of_color = ('red', 'yellow', 'green')
		self.__dict_of_color = {0: ('red', time_r), 1: ('yellow', time_y), 2: ('green', time_g)}

	def running(self, k):
		""" :param k: int, Сколько раз переключиться световор """

		for _ in range(k):
			print(self.__color)
			if self.__color == 'red':
				self.__color = 'yellow'
				sleep(7)
			elif self.__color == 'yellow':
				self.__color = 'green'
				sleep(2)
			else:
				self.__color = 'red'
				sleep(5)

	def running_2(self, k):
		""":param k: int, Сколько полных циклов переключиться световор"""

		for _ in range(k):
			for c in range(3):
				print(self.__list_of_color[c])
				if c == 0:
					sleep(7)
				elif c == 1:
					sleep(2)
				else:
					sleep(5)

	def running_3(self, k):
		""":param k: int, Сколько полных циклов переключиться световор"""

		for _ in range(k):
			self.__index_of_color = 0
			while self.__index_of_color < 3:
				print(self.__list_of_color[self.__index_of_color])
				if self.__index_of_color == 0:
					sleep(7)
				elif self.__index_of_color == 1:
					sleep(2)
				else:
					sleep(5)
				self.__index_of_color += 1

	def running_4(self, k):
		""":param k: int, Сколько полных циклов переключиться световор"""

		for _ in range(k):
			for c in range(3):
				self.__index_of_color = c
				print(self.__dict_of_color.get(self.__index_of_color)[0])
				sleep(self.__dict_of_color.get(self.__index_of_color)[1])


tl = TrafficLight(init_color='red', time_r=4, time_y=3, time_g=5)
tl.running(5)
tl.running_2(5)
tl.running_3(5)
tl.running_4(5)
