# 3. Задание
# Пользователь вводит месяц в виде целого числа от 1 до 12.
# Сообщить, к какому времени года относится месяц (зима, весна, лето, осень).
# Напишите решения через list и dict.

seasons_short = ['зима', 'весна', 'лето', 'осень']
seasons = ['зима', 'зима', 'весна', 'весна', 'весна', 'лето', 'лето', 'лето', 'осень', 'осень', 'осень', 'зима']
months = ['Январь', 'Февраль', 'Март', 'Апрель', 'Май', 'Июнь', 'Июль', 'Август', 'Сентябрь', 'Октябрь', 'Ноябрь',
          'Декабрь']
seasons_by_month = {1: 'зима', 2: 'зима', 3: 'весна', 4: 'весна', 5: 'весна', 6: 'лето', 7: 'лето', 8: 'лето',
                    9: 'осень', 10: 'осень', 11: 'осень', 12: 'зима'}
seasons_by_month_tk = {'Январь': 'зима', 'Февраль': 'зима', 'Март': 'весна', 'Апрель': 'весна', 'Май': 'весна',
                       'Июнь': 'лето', 'Июль': 'лето', 'Август': 'лето',
                       'Сентябрь': 'осень', 'Октябрь': 'осень', 'Ноябрь': 'осень', 'Декабрь': 'зима'}

while True:
    month_var = input('Введите месяц в виде целого числа от 1 до 12: ')
    if month_var.isdigit():
        month_var = int(month_var)
        if month_var in range(1, 13):
            break
    print('Ошибка ввода данных. Повторите ввод.')

month_arh = month_var  # так как несколько вариантов решений, то сохраняем введеное пользователем значение

# Вариант 1: Список сезонов без повторений элементов индекс с помощью формулы

month_var = month_arh  # восстанавливаем значение из архива.
print(f'Время года для месяца {months[month_var-1]} - {seasons_short[(month_var // 3 % 4)]}.')

# Вариант 2: список сезонов с дублями элементов

month_var -= 1  # вычитаем 1, чтобы было удобнее работать с элементами списка
print(f'Время года для месяца {months[month_var]} - {seasons[month_var]}.')

# Вариант 3: Вывод времени года из словаря с числовым ключом

month_var = month_arh  # восстанавливаем значение из архива.
print(f'Время года для месяца {months[month_var-1]} - {seasons_by_month.get(month_var)}.')

# Вариант 4: Вывод времени года из словаря со строковым ключом

month_var = month_arh-1  # восстанавливаем значение из архива и вычитаем 1 для удобства работы со списком.
print(f'Время года для месяца {months[month_var]} - {seasons_by_month_tk.get(months[month_var])}.')
