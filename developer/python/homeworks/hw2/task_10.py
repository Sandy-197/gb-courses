# Задача 10:
# На столе лежат n монеток.
# Некоторые из них лежат вверх решкой, а некоторые – гербом.
# Определите минимальное число монеток, которые нужно перевернуть,
# чтобы все монетки были повернуты вверх одной и той же стороной.
# Выведите минимальное количество монет, которые нужно перевернуть
import random
n = int(input("Введите кол-во монет: "))
coin_eagle = 0
coin_reshka = 0
for i in range(n):
    coin = random.randint(0, 1)
    print(coin, end=" ")
print(
    f"\nМинимальное кол-во монет, которые надо перевернуть: {coin_reshka if coin_eagle>coin_reshka else coin_eagle} ")
