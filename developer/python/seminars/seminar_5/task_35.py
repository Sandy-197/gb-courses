# Задача №35.
# Решение в группах Напишите функцию,
# которая принимает одно число и проверяет,
# является ли оно простым
# Напоминание:
# Простое число - это число, которое имеет 2 делителя: 1 и n(само число)
# Input: 5 Output: yes

def is_simple(number) -> bool:
    if number in [1, 2]:
        return True
    if number % 2 == 0:
        return False
    for i in range(3, number // 2, 2):
        if number % i == 0:
            return False
    return True


num = int(input("Введите число, которое надо проверить: "))
print(f"{num} - "+("Простое" if is_simple(num) else "Составное"))
