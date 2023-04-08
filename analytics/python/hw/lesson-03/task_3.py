# Задаие 3.
# Реализовать функцию my_func(),
# которая принимает три позиционных аргумента и
# возвращает сумму наибольших двух аргументов.

# Проверка на валидность аргументов сделана через try.

def my_func(var_1, var_2, var_3):
    """ Возвращает сумму двух наибольших аргументов
        или None в случае ошибки аргументов.

        позиционные аргументы:
        var_1 -- число
        var_2 -- число
        var_3 -- число
    """

    try:
        var_1 = float(var_1)
        var_2 = float(var_2)
        var_3 = float(var_3)
    except ValueError or TypeError:
        return None

    res_12 = var_1 + var_2
    res_13 = var_1 + var_3
    res_23 = var_2 + var_3

    return max(res_12, res_13, res_23)


print(my_func('-4', 3, 44))
