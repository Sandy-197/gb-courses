# 7. Задание
# Спортсмен занимается ежедневными пробежками.
# В первый день его результат составил a километров.
# Каждый день спортсмен увеличивал результат на 10% относительно предыдущего.
# Требуется определить номер дня, на который результат спортсмена составит не менее b километров.
# Программа должна принимать значения параметров a и b и выводить одно натуральное число — номер дня.

while True:  # проверка что введено число
    a = input('Введите результат в 1 день пробежки:')
    if not a.isdigit():
        print('Ошибка. Вы ввели не корректное значение!\nПовторите ввод.')
    else:
        a = int(a)
        break

while True:  # проверка что введено число
    b = input('Введите желаемый результат:')
    if not b.isdigit():
        print('Ошибка. Вы ввели не корректное значение!\nПовторите ввод.')
    else:
        b = int(b)
        break

i = 1

while a < b:
    a *= 1.1
    i += 1

print(f'На {i} день спортсмен достиг результата — не менее {b} км.')
