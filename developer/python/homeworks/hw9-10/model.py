class PhoneBook:

    def __init__(self, path: str = ''):
        self._phone_book: list[dict[str, str]] = []
        self._path = path

    def load_pb(self):
        with open(self._path, 'r', encoding='UTF-8') as file:
            data = file.readlines()
        for contact in data:
            contact = contact.strip().split(':')
            self._phone_book.append(
                {'name': contact[0], 'phone': contact[1], 'comment': contact[2]})

    def save_pb(self):
        data = []
        for contact in self._phone_book:
            data.append(':'.join([value for value in contact.values()]))
        with open(self._path, 'w', encoding='UTF-8') as file:
            file.write('\n'.join(data))

    def get_pb(self) -> list[dict[str, str]]:
        return self._phone_book

    # Для дальнейшей разработки, если добавлять id у контакта 
    def get_max_id(self) -> int:
        if self._phone_book:
            max_id = max(int(value['id']) for value in self._phone_book)+1
        else:
            max_id = 1
        return max_id

    def add_contact(self, contact: dict[str, str]):
        self._phone_book.append(contact)
        return contact.get('name')

    def del_contact(self, index: int):
        return self._phone_book.pop(index-1).get('name')

    def search_pb(self, word: str) -> list[dict[str, str]]:
        result: list[dict[str, str]] = []
        for contact in self._phone_book:
                for field in contact.values():
                    if word.lower().strip() in field.lower().strip():
                        result.append(contact)
                        break
        return result

    def change_pb(self, contact: dict[str, str], index: int):
        if len(contact['name']) > 0:
            self._phone_book[index-1]['name'] = contact['name']
        if len(contact['phone']) > 0:
            self._phone_book[index-1]['phone'] = contact['phone']
        if len(contact['comment']) > 0:
            self._phone_book[index-1]['comment'] = contact['comment']
