def reverse_list(n) -> str:
    return ('1' if n==1 else f'{n} -> {reverse_list(n-1)}')

def reverse_str(st) -> str:
    return (st if len(st)==1 else st[-1] + reverse_str(st[:-1]))


num = int(input('Type your N: '))
print(reverse_list(num))
print(reverse_str("qwertyu"))
