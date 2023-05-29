"""
Создать телефонный справочник с возможностью импорта и экспорта данных в формате .txt. 
Фамилия, имя, отчество, номер телефона - данные, которые должны находиться в файле.

1. Программа должна выводить данные
2. Программа должна сохранять данные в текстовом файле
3. Пользователь может ввести одну из характеристик для поиска определенной записи
(Например имя или фамилию человека)
4. Использование функций. Ваша программа не должна быть линейной

1. Открыть файл
2. Сохранить файл
3. Показать тк
4. Добавить контакт
5. Найти контакт
6. Изменить контакт
7. Удалить контакт
8. Выход из программы
"""
import json
import os

fileNameJson = os.path.dirname(__file__)+"\\"+"data_file.json"
fileNameTxt = os.path.dirname(__file__)+"\\"+"data_file.txt"

menu = {'1': 'Прочитать тел книгу из файла Json',
        '2': 'Сохранить тел книгу в файл Json',
        '3': 'Прочитать тел книгу из файла Txt',
        '4': 'Сохранить тел книгу в файл Txt',
        '5': 'Показать тел книгу',
        '6': 'Добавить контакт',
        '7': 'Найти контакт',
        '8': 'Изменить контакт',
        '9': 'Удалить контакт',
        '0': 'Выход из программы'}

# data = {'id': {'name': '', 'phone': ''}}
# data = dict[int:dict[str,str]]
data = {}


def saveDataJson():
    with open(fileNameJson, "w", encoding='utf-8') as write_file:
        write_file.write(json.dumps(data))  # сбрасывает данные в файл


def saveDataTxt():
    with open(fileNameTxt, "w", encoding='utf-8') as write_file:
        temp = ''
        for key, item in data.items():
            temp += str(key)+':'+item['name']+':'+item['phone']+'\n'
        write_file.write(temp)  # сбрасывает данные в файл


def readDataJson():
    global data
    if os.path.exists(fileNameJson):
        with open(fileNameJson, "r", encoding='utf-8') as read_file:
            temp = json.loads(read_file.read())
            if temp:
                date = {}
                for key, value in temp.items():
                    data[int(key)] = value
            else:
                print(f"Error. Phonebook {fileNameJson} is empty.")
    else:
        print(f"Error. No file name {fileNameJson}.")


def readDataTxt():
    global data
    if os.path.exists(fileNameTxt):
        data = {}
        with open(fileNameTxt, "r", encoding='utf-8') as read_file:
            temp = read_file.read().split('\n')
            if len(temp) > 0:
                for i in range(len(temp)):
                    tmp = temp[i].split(':')
                    if len(tmp)==3:
                        data[int(tmp[0])] = {'name': tmp[1], 'phone': tmp[2]}
            else:
                print(f"Error. Phonebook {fileNameTxt} is empty.")
    else:
        print(f"Error. No file name {fileNameTxt}.")


def showData():
    print("ID "+"Name"+" "*16+"Phone")
    print('-'*63)
    for key, item in data.items():
        print(f"{key:<3}{item['name']:<20}{item['phone']:<20}")
    print('-'*63)


def addContact():
    contact_id = max(data.keys()) + 1 if len(data) > 0 else 1
    name = input('Введите ФИО: ')
    phone = input('Введите номер телефона: ')
    data[contact_id] = {'name': name, 'phone': phone}


def deleteContact():
    showData()
    contact_id = int(input('Введите ID контакта для удаления: '))
    if contact_id in data.keys():
        data.pop(contact_id)


def changeContact():
    showData()
    contact_id = int(input('Какой id контакта поменять? '))
    print(data[contact_id])
    name = input('Введите имя: ')
    phone = input('Введите номер телефона: ')
    if len(name) > 0:
        data[contact_id]['name'] = name
    if len(phone) > 0:
        data[contact_id]['phone'] = phone


def findContact():
    command = int(input(
        'Меню: \n1. Искать по id \n2. Искать по имени \n3. Искать по телефону \n:'))
    match command:
        case 1:
            print(data[int(input('Введите id: '))])
        case 2:
            fn = input('Введите имя: ').lower()
            print('-'*60)
            for key, item in data.items():
                if item['name'].lower().find(fn) != -1:
                    print(f"{key:<3}{item['name']:<20}{item['phone']:<20}")
            print('-'*60)
        case 3:
            fn = input('Введите номер телефона: ')
            print('-'*60)
            for key, item in data.items():
                if item['phone'].find(fn) != -1:
                    print(f"{key:<3}{item['name']:<20}{item['phone']:<20}")
            print('-'*60)


def menuContacts(menu):
    for key, item in menu.items():
        print(key, item)


command = -1
readDataTxt()

while command != 0:
    print("Меню:")
    menuContacts(menu)
    command = input('Введите команду: ')
    if len(command) > 0:
        command = int(command)
    else:
        command = 0
    match command:
        case 1:
            readDataJson()
            showData()
        case 2:
            saveDataJson()
        case 3:
            readDataTxt()
            showData()
        case 4:
            saveDataTxt()
        case 5:
            showData()
        case 6:
            addContact()
            saveDataJson()
            saveDataTxt()
        case 7:
            findContact()
        case 8:
            changeContact()
            saveDataJson()
            saveDataTxt()
        case 9:
            deleteContact()
            saveDataJson()
            saveDataTxt()
        case 0:
            break
