# Задача №49.
# Планеты вращаются вокруг звезд по эллиптическим орбитам.
# Назовем самой далекой планетой ту, орбита которой имеет самую большую площадь.
# Напишите функцию find_farthest_orbit(list_of_orbits),
# которая среди списка орбит планет найдет ту,
# по которой вращается самая далекая планета.
# Круговые орбиты не учитывайте:
# вы знаете, что у вашей звезды таких планет нет,
# зато искусственные спутники были были запущены на круговые орбиты.
# Результатом функции должен быть кортеж,
# содержащий длины полуосей эллипса орбиты самой далекой планеты.
# Каждая орбита представляет из себя кортеж из пары чисел - полуосей ее эллипса.
# Площадь эллипса вычисляется по формуле S = pi*a*b, где a и b - длины полуосей эллипса.
# При решении задачи используйте списочные выражения.
# Гарантируется, что самая далекая планета ровно одна.
import random


def find_farthest_orbit(lst):
    return max(map(lambda item: (item[0]*item[1], item), filter(lambda item: item[0] != item[1], lst)))


orbits = [(random.randint(1, 10), random.randint(1, 10))
          for _ in range(int(input("Введите колво планет: ")))]

print(orbits, find_farthest_orbit(orbits))

# print(max(map(lambda item: (item[0]*item[1],item),filter(lambda item: item[0]!=item[1],orbits:=[(random.randint(1,10),random.randint(1,10)) for _ in range(int(input("Введите колво планет: ")))]))),orbits)
