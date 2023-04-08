# Задание 5.
# Реализовать класс Stationery (канцелярская принадлежность).
# Определить в нём атрибут title (название) и метод draw (отрисовка).
# Метод выводит сообщение «Запуск отрисовки»
# Создать три дочерних класса Pen (ручка), Pencil (карандаш), Handle (маркер)
# В каждом классе реализовать переопределение метода draw.
# Для каждого класса метод должен выводить уникальное сообщение;
# создать экземпляры классов и проверить,
# что выведет описанный метод для каждого экземпляра.

class Stationery:
	def __init__(self, title=''):
		self.title = title

	def draw(self):
		return "Запуск отрисовки"


class Pen(Stationery):
	def __init__(self):
		super().__init__('Ручка')

	def draw(self):  # переопределяем метод, но внутри вызываем метод родителя (для разнообразия)
		print(super().draw(), self.title)


class Pencil(Stationery):
	def __init__(self):
		super().__init__('Карандаш')

	def draw(self):
		print(f'Рисуем {self.title}')


class Handle(Stationery):
	def __init__(self):
		super().__init__('Маркер')

	def draw(self):
		print(f'Рисуем {self.title}')


st = Stationery('Фломастер')
print(st.draw())

pen = Pen()
pencil = Pencil()
handle = Handle()

pen.draw()
pencil.draw()
handle.draw()
