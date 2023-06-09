# 2. Задание
# Пользователь вводит время в секундах.
# Переведите время в часы, минуты, секунды и выведите в формате чч:мм:сс.
# Используйте форматирование строк.
# Исправлен тип файла

# приведен способ решения конкретной задачи без использования дополнительных переменных.
# так как по условия задачи, полученные данные нам нужны только для вывода на экран.

while True:  # проверка что введено число
    ss = input('Введите кол-во секунд в виде натурального числа:')
    if not ss.isdigit():
        print('Ошибка. Вы ввели не натуральное число!\nПовторите ввод.')
    else:
        ss = int(ss)  # изменение типа данных с str на int
        break

print('ЧЧ:ММ:СС')  # вывод шапки
print(f'{ss // 3600 % 24:02}:{ss % 3600 // 60:02}:{ss % 60:02}')  # вывод результата
