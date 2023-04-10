# Задача 8:
# Требуется определить, можно ли от шоколадки размером n × m долек отломить k долек,
# если разрешается сделать один разлом по прямой между дольками
# (то есть разломить шоколадку на два прямоугольника).
# *Пример:*
# 3 2 4 -> yes
# 3 2 1 -> no
# Добавлена ветка hw1


n = int(input("Введите кол-во плиток в ширину:"))
m = int(input("Введите кол-во плиток в высоту:"))
k = int(input("Введите кол-во плиток, которые вы хотите отломить за один раз:"))

if (k % n == 0 and k >= n and k <= (m-1)*n) or (k % m == 0 and k >= m and k <= (n-1)*m):
    print(f"{n}х{m} - {k} -> yes")
else:
    print(f"{n}х{m} - {k} -> no")
