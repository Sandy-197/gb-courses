# Задание 4.
# Реализуйте базовый класс Car.
# У класса должны быть следующие атрибуты: speed, color, name, is_police (булево).
# А также методы: go, stop, turn(direction), которые должны сообщать,
# что машина поехала, остановилась, повернула (куда);
#
# Опишите несколько дочерних классов: TownCar, SportCar, WorkCar, PoliceCar;
#
# Добавьте в базовый класс метод show_speed,
# который должен показывать текущую скорость автомобиля;
#
# Для классов TownCar и WorkCar переопределите метод show_speed.
# При значении скорости свыше 60 (TownCar) и 40 (WorkCar)
# должно выводиться сообщение о превышении скорости.
#
# Создайте экземпляры классов,
# передайте значения атрибутов.
# Выполните доступ к атрибутам,
# выведите результат.
# Вызовите методы и покажите результат.

class Car:
	"""Класс Car"""

	def __init__(self, name='', color='', speed=0.0, is_police=False):
		"""	Конструктор класса Car\n
			объявляем атрибуты класса:\n
			:param name: string, Название машины
			:param color: string, Цвет машины
			:param speed: float, Скорость машины в км/ч
			:param is_police: boolean, True если полицейская машины, False для остальных
		"""
		self.speed = speed
		self.color = color
		self.name = name
		self.is_police = is_police

	def go(self, speed):
		"""	Метод класса Car\n
			:return: string, 'name поехала', name название машины
		"""
		self.speed = speed
		return f'{self.name} поехала со скоростью {self.speed}'

	def stop(self):
		"""	Метод класса Car\n
			:return: string 'name остановилась', name название машины
		"""
		self.speed = 0
		return f'{self.name} остановилась'

	def turn(self, direction):
		"""	Метод класса Car\n
			:return: string 'name повернула direction', name название машины, direction направление
		"""
		return f'{self.name} повернула {direction}' if self.speed > 0 else f'Повернуть невозможно, машина {self.name} остановлена.'

	def show_speed(self):
		"""	Метод класса Car\n
			:return speed: float, скорость автомобиля
		"""
		return self.speed


class TownCar(Car):
	"""	Класс TownCar наследник Класса Car\n"""
	speed_limit = 60

	def __init__(self, name='', color=''):
		"""	Конструктор класса TownCar\n
			:param name: string, Название машины
			:param color: string, Цвет машины
		"""
		super().__init__(name=name, color=color, speed=0.0, is_police=False)

	def show_speed(self):
		""" Показывает текущую скорость автомобиля\n
			И если превышает установленный лимит, то указывает на это
		"""
		return f'{self.speed} - Превышаете!!!' if self.speed > self.speed_limit else self.speed


class WorkCar(Car):
	"""	Класс WorkCar наследник Класса Car\n"""
	speed_limit = 40

	def __init__(self, name='', color=''):
		"""	Конструктор класса WorkCar\n
			:param name: string, Название машины
			:param color: string, Цвет машины
		"""
		super().__init__(name=name, color=color, speed=0.0, is_police=False)

	def show_speed(self):
		""" Показывает текущую скорость автомобиля\n
			Сообщает о превышении
		"""
		return f'{self.speed} - Превышаете!!!' if self.speed > self.speed_limit else self.speed


class SportCar(Car):
	"""	Класс SportCar наследник Класса Car\n"""

	def __init__(self, name='', color=''):
		"""	Конструктор класса SportCar\n
			:param name: string, Название машины
			:param color: string, Цвет машины
		"""
		super().__init__(name=name, color=color, speed=0.0, is_police=False)


class PoliceCar(Car):
	"""	Класс PoliceCar наследник Класса Car\n"""

	def __init__(self, name='', color=''):
		"""	Конструктор класса PoliceCar\n
			:param name: string, Название машины
			:param color: string, Цвет машины
		"""
		super().__init__(name=name, color=color, speed=0.0, is_police=True)


car_1 = TownCar('Mazda', 'бежевый')
car_2 = PoliceCar('Ford Explorer', 'бело/черный')
car_3 = SportCar('Ford mustang', 'красный')
car_4 = WorkCar('Трактор', 'зеленый')

print(car_1.go(30))
print(car_2.go(50))
print(car_3.go(100))
print(car_4.go(80))

print(f'{car_1.name} текущая скорость {car_1.show_speed()}')
print(f'{car_2.name} текущая скорость {car_2.show_speed()}')
print(f'{car_3.name} текущая скорость {car_3.show_speed()}')
print(f'{car_4.name} текущая скорость {car_4.show_speed()}')

print(car_1.turn('right'))
print(car_1.turn('left'))
print(car_1.turn('right'))
print(car_1.turn('left'))

print(car_1.stop())
print(car_1.turn('left'))  # машина не повернет потому, что остановлена
print(car_2.stop())
