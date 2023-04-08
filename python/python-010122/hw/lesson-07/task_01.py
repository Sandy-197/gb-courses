# Задание 1.
# Реализовать класс Matrix (матрица).
# Обеспечить перегрузку конструктора класса (метод __init__()),
# который должен принимать данные (список списков) для формирования матрицы.
# Подсказка: матрица — система некоторых математических величин,
# расположенных в виде прямоугольной схемы.
# Примеры матриц: 3 на 2, 3 на 3, 2 на 4.

# 31    32         3    5    32        3    5    8    3
# 37    43         2    4    6         8    3    7    1
# 51    86        -1   64   -8

# Следующий шаг — реализовать перегрузку метода __str__() для вывода матрицы в привычном виде.
# Далее реализовать перегрузку метода __add__() для реализации
# операции сложения двух объектов класса Matrix (двух матриц).
# Результатом сложения должна быть новая матрица.
# Подсказка: сложение элементов матриц выполнять поэлементно —
# первый элемент первой строки первой матрицы складываем с
# первым элементом первой строки второй матрицы и т.д.

class Matrix:

	def __init__(self, matrix):
		""" Конструктор класса Matrix \n
			Инициализирует переменные, \n
			дорабатывает битую матрицу \n
			:param matrix: список списков
		"""
		self.__columns = max([len(m) for m in matrix]) if len(matrix) > 0 else 0
		self.__rows = len(matrix)
		self.__dimensions = (self.__columns, self.__rows)
		self.matrix = matrix
		self.__rep()

	def __rep(self):
		""" Приватный метод.
			Ремонтирует битую матрицу \n
			Если в матрице отсутствую элементы, \n
			то заполняет их нулями, \n
			для создания правильной матрицы
		"""
		for m in self.matrix:
			while len(m) < self.columns:
				m.append(0)

	@property
	def rows(self):
		"""Возвращает кол-во строк матрицы"""
		return self.__rows

	@property
	def columns(self):
		"""Возвращает кол-во колонок матрицы"""
		return self.__columns

	@property
	def dimensions(self):
		"""Возвращает кортеж с размерностью матрицы"""
		return self.__dimensions

	def str(self):
		"""Выводит матрицу в привычном виде"""
		#  Первый вариант сбора строки, двойной цикл. Сложно читать.
		return str('\n'.join(['\t'.join([str(el) for el in one_s]) for one_s in self.matrix]))

	def __str__(self):
		"""Выводит матрицу в привычном виде"""
		#  Второй вариант сбора строки, более удобный
		return '\n'.join(['\t'.join(map(str, one_s)) for one_s in self.matrix])

	@staticmethod
	def add(a, b):
		"""Статичный метод сложения двух матриц"""
		#  складывает две любые матрицы однострочный вариант,
		#  но PEP его все равно разбивает на несколько строк,
		#  поэтому ниже вариант __add__ более читаемый
		#  объявлен как @staticmethod, так как в нем не используется сам объект
		return Matrix(
			[[(a.matrix[i][j] if i < a.rows and j < a.columns else 0) +
			  (b.matrix[i][j] if i < b.rows and j < b.columns else 0)
			  for j in range(a.columns if a.columns > b.columns else b.columns)]
			 for i in range(a.rows if a.rows > b.rows else b.rows)])

	def __add__(self, other):
		"""Складывает две разно размерные матрицы"""
		#  Развернутый цикл по суммированию матриц.
		#  Так как однострочный PEP все равно привел к многострочному виду.
		#  А читаемость у данной реализации выше.
		#  Можно сразу создать объект, можно создать здесь просто список списков.
		#  А объект создавать в return.
		#  Также так как нам уже известны размеры матриц, которые мы суммируем,
		#  можно сразу создать пустую матрицу максимально размерности.
		#  Тогда не будет append, а будет просто присвоение,
		#  но это уже надо смотреть, что будет работать быстрее.
		#  Для нашей задачи это не требуется

		m = Matrix([])
		for i in range(self.rows if self.rows > other.rows else other.rows):
			m.matrix.append([])
			for j in range(self.columns if self.columns > other.columns else other.columns):
				m.matrix[i].append((self.matrix[i][j] if i < self.rows and j < self.columns else 0) + (
					other.matrix[i][j] if i < other.rows and j < other.columns else 0))
		return m


list_1 = [[1, 2, 3], [2, 3], [6, 4, 5], [8, 9, 10]]
list_2 = [[5], [3, 4], [5, -6, 7, 4]]

matrix_1 = Matrix(list_1)
matrix_2 = Matrix(list_2)
print(matrix_1)
print('+')
print(matrix_2)
print('-----------------')
print(matrix_1 + matrix_2)
