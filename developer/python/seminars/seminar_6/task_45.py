# Два различных натуральных числа n и m называются дружественными,
# если сумма делителей числа n (включая 1, но исключая само n) равна числу m и наоборот.
# Например, 220 и 284 – дружественные числа.
# По данному числу k выведите все пары дружественных чисел,
# каждое из которых не превосходит k.
# Программа получает на вход одно натуральное число k,
# не превосходящее 105.
# Программа должна вывести все пары дружественных чисел,
# каждое из которых не превосходит k.

def summarize(number, sum=0):
    for item in range(1, number//2+1):
        if number % item == 0:
            sum += item
    return sum

k = 100000
print(my_list := [i for i in range(k)])
lst = list()

for i in range(66928,len(my_list)):
    item = my_list[i]
    sum1 = summarize(item)
    sum2 = summarize(sum1)
    if (sum2 == item) and (item < sum1):
        print(item, sum1)
        lst.append((item, sum1))
print(lst)


