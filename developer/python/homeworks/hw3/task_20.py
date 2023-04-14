# *Задача 20:
# * В настольной игре Скрабл (Scrabble) каждая буква имеет определенную ценность.
# В случае с английским алфавитом очки распределяются так:
# A, E, I, O, U, L, N, S, T, R – 1 очко;
# D, G – 2 очка;
# B, C, M, P – 3 очка;
# F, H, V, W, Y – 4 очка;
# K – 5 очков;
# J, X – 8 очков;
# Q, Z – 10 очков.
# А русские буквы оцениваются так: 
# А, В, Е, И, Н, О, Р, С, Т – 1 очко; 
# Д, К, Л, М, П, У – 2 очка; 
# Б, Г, Ё, Ь, Я – 3 очка; 
# Й, Ы – 4 очка; 
# Ж, З, Х, Ц, Ч – 5 очков; 
# Ш, Э, Ю – 8 очков; 
# Ф, Щ, Ъ – 10 очков.
# Напишите программу, которая вычисляет стоимость введенного пользователем слова.
# Будем считать, что на вход подается только одно слово,
# которое содержит либо только английские, либо только русские буквы.
# *Пример:*
# ноутбук = 12

# вариант 1:
# не вижу смысла разбивать словари на русский и англ. 
# Объединил словари в одни общий. для наглядности записал через + 
# чтобы опнимать где латинские где русские
dict = {
    1: "AEIOULNSTR"+"АВЕИНОРСТ",
    2: "DG"+"ДКЛМПУ",
    3: "BCMP"+"БГЁЬЯ",
    4: "FHVWY"+"ЙЫ",
    5: "K"+"ЖЗХЦЧ",
    8: "JX"+"ШЭЮ",
    10: "QZ"+"ФЩЪ"
}

st = input("Введите слово: ")
count = 0
for ch in st.upper():
    for key, value in dict.items():
        count += key * value.count(ch)

print(f"Слово {st} -> {count} оч.")

# вариант 2: более красивый словарь :)
dict = {
    1: ("AEIOULNSTR","АВЕИНОРСТ"),
    2: ("DG","ДКЛМПУ"),
    3: ("BCMP","БГЁЬЯ"),
    4: ("FHVWY","ЙЫ"),
    5: ("K","ЖЗХЦЧ"),
    8: ("JX","ШЭЮ"),
    10: ("QZ","ФЩЪ")
}
#st = input("Введите слово: ")
count = 0
for ch in st.upper():
    for key, value in dict.items():
        count += key * (value[0].count(ch)+value[1].count(ch))

print(f"Слово {st} -> {count} оч.")

