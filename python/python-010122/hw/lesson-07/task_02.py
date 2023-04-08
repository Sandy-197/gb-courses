# Задание 2.
# Реализовать проект расчёта суммарного расхода ткани на производство одежды.
#
# Основная сущность (класс) этого проекта — одежда,
# которая может иметь определённое название.
# К типам одежды в этом проекте относятся пальто и костюм.
# У этих типов одежды существуют параметры: размер (для пальто) и рост (для костюма).
# Это могут быть обычные числа: V и H, соответственно.
# Для определения расхода ткани по каждому типу одежды использовать формулы:
# для пальто (V/6.5 + 0.5),
# для костюма (2*H + 0.3).
#
# Проверить работу этих методов на реальных данных.
# Реализовать общий подсчет расхода ткани.

# Проверить на практике полученные на этом уроке знания:
# реализовать абстрактные классы для основных классов проекта,
# проверить на практике работу декоратора @property.

from abc import ABC, abstractmethod


class Clothes(ABC):
	def __init__(self, title, t):
		"""	Конструктор класса Clothes
			:param title: string - Название элемента одежды
			:param t: string - Тип одежды, (пальто, костюм и т.д)
		"""

		self.title = title
		self.__t = t

	@abstractmethod
	def calc_textile(self):
		"""Абстрактный метод, должен быть переопределен в потомках"""
		pass

	@property
	def t(self):
		"""Возвращает тип одежды"""
		return self.__t


class Coat(Clothes):

	def __init__(self, title, size):
		"""	Конструктор класса Coat
			:param title: string - название пальто
			:param size: int - размер
			Можно реализовать проверки целостности данных при необходимости
		"""

		self.size = int(size)
		super().__init__(title, 'пальто')

	@property
	def size(self):
		"""Возвращает размер"""
		return self.__size

	@size.setter
	def size(self, size):
		"""	Устанавливает размер\n
			Если устанавливаемый размер <0 то устанавливает его в 0\n
			Можно организовать дополнительные проверки при необходимости
		"""

		if size <= 0:
			self.__size = 0
		else:
			self.__size = size

	def calc_textile(self):
		"""Возвращает кол-во метров ткани по формуле (size/6.5+0.5) округленное до 3 знаков"""
		return round(self.__size / 6.5 + 0.5, 3)


class Suit(Clothes):

	def __init__(self, title, growth):
		"""	:param title: string название костюма\n
			:param growth: int либо string, но содержащий цифры
			проверка на то, что в строке цифры не реализована
		"""

		self.__growth = float(growth)
		super().__init__(title, 'костюм')

	@property
	def growth(self):
		"""Возвращает рост"""
		return self.__growth

	@growth.setter
	def growth(self, growth):
		"""	Устанавливает рост\n
			Если устанавливаемый рост <0 то устанавливает его в 0\n
			Можно реализовать дополнительные проверки
		"""

		if growth <= 0:
			self.__growth = 0
		else:
			self.__growth = growth

	def calc_textile(self):
		"""Возвращает кол-во метров ткани по формуле (2*growth+0.3) округленное до 3 знаков"""
		return round(2 * self.__growth + 0.3, 3)


coat = Coat('Шикарное', 20)
suit = Suit('Великолепный', '197')

print(f"На {coat.t} '{coat.title}' размера {coat.size} потребуется {coat.calc_textile()}м ткани;")
print(f"На {suit.t} '{suit.title}' роста {suit.growth} потребуется {suit.calc_textile()}м ткани;")
print(f"Всего необходимо {coat.calc_textile()+suit.calc_textile()}м ткани.")
