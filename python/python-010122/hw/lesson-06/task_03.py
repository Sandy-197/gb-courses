# Задание 3.
# Реализовать базовый класс Worker (работник).
# Определить атрибуты: name, surname, position (должность), income (доход);
# Последний атрибут должен быть защищённым и ссылаться на словарь,
# содержащий элементы: оклад и премия, например, {"wage": wage, "bonus": bonus};
#
# Cоздать класс Position (должность) на базе класса Worker;
# в классе Position реализовать методы:
# получения полного имени сотрудника (get_full_name)
# дохода с учётом премии (get_total_income)
#
# проверить работу примера на реальных данных:
# создать экземпляры класса Position,
# передать данные,
# проверить значения атрибутов,
# вызвать методы экземпляров.
#

class Worker:
	""" Класс Worker(Работник) """

	def __init__(self, name, surname, position, income):
		"""	Конструктор класса Worker\n
			:param name: Имя сотрудника
			:param surname: Фамилия сотрудника
			:param position: Должность сотрудника
			:param income: Словарь {"wage": 0, "bonus": 0}
		"""
		self.name = name
		self.surname = surname
		self.position = position
		self._income = income

	def get_income(self):
		return self._income


class Position(Worker):
	""" Position (Должность) наследник класса Worker"""

	def __init__(self, name, surname, position, income):
		""" Конструктор класса Position\n
			:param name: Имя сотрудника
			:param surname: Фамилия сотрудника
			:param position: Должность сотрудника
			:param income: Словарь {"wage": 0, "bonus": 0}
		"""
		super().__init__(name, surname, position, income)

	def get_full_name(self):
		"""	Возвращает полное Фамилию и Имя сотрудника через пробел\n
			:return: string - Фамилия пробел Имя
		"""
		return str(f'{self.surname} {self.name}')

	def get_total_income(self):
		"""	Возвращает доход сотрудника с учётом бонуса\n
			:return: float - Доход сотрудника
		"""
		return str(f'{sum(self._income.values())}')


# Создание объектов
worker_1 = Position('Ivan', 'Ivanov', 'Director', {"wage": 100000, "bonus": 10000})
worker_2 = Position('Petr', 'Petrov', 'Manager', {"wage": 10000, "bonus": 800})

# Вывод атрибутов на прямую, переносы строк сделаны исключительно для читабильности
print(f'For worker_1:\n \
Name:{worker_1.name}\n \
Surname:{worker_1.surname}\n \
Position:{worker_1.position}\n \
_Income:{worker_1._income}\n \
Правильный возрат защищенного атрибута:{worker_1.get_income()}')

print(f'For worker_2:\n \
Name:{worker_2.name}\n \
Surname:{worker_2.surname}\n \
Position:{worker_2.position}\n \
_Income:{worker_2._income}\n \
Правильный возрат защищенного атрибута:{worker_1.get_income()}')

# Вывод через методы
print(f'Полное имя: {worker_1.get_full_name()} - Доход: {worker_1.get_total_income()}')
print(f'Полное имя: {worker_2.get_full_name()} - Доход: {worker_2.get_total_income()}')
