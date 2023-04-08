# Задание 1.
# Реализовать функцию, принимающую два числа (позиционные аргументы) и выполняющую их деление.
# Числа запрашивать у пользователя,
# предусмотреть обработку ситуации деления на ноль.

# Проверка на валидность аргументов сделана за счет трансформации строк

def my_isreal(var):
    """ Возвращает True если любое число, и False если не число """
    var = str(var).replace(',', '.')
    return (var.count('-') == 0 or (var.count('-') == 1 and var.index('-') == 0)) and var.replace('.', '').replace('-',
                                                                                                                   '').isdigit()


def div_func(var_1, var_2):
    """ Возвращает частное от деления
        или None если деление не возможно.

        позиционные аргументы:
        var_1 -- делимое
        var_2 -- делитель
    """

    var_1 = float(var_1.replace(',', '.')) if my_isreal(var_1) else None
    var_2 = float(var_2.replace(',', '.')) if my_isreal(var_2) and float(var_2.replace(',', '.')) != 0 else None

    if (var_1 and var_2) is None:
        return None

    return float(var_1) / float(var_2)


res = div_func(input('Введите делимое:'), input('Введите делитель:'))
if res is None:
    print('Введены ошибочные данные')
else:
    print(round(res, 6))

# print(div_func('3', 4))  # данные могут вы переданы как строкой так и числом
