lst = list()
lst.append({'id': '2', 'name': 'alex',
           'phone': 'sffsfd', 'comments': 'sfdsdfs'})
lst.append({'id': '3', 'name': 'alex',
           'phone': 'sffsfd', 'comments': 'sfdsdfs'})
lst.append({'id': '5', 'name': 'alex',
           'phone': 'sffsfd', 'comments': 'sfdsdfs'})
lst.append({'id': '1', 'name': 'alex',
           'phone': 'sffsfd', 'comments': 'sfdsdfs'})
lst.append({'id': '4', 'name': 'alex',
           'phone': 'sffsfd', 'comments': 'sfdsdfs'})
lst.append({'id': '8', 'name': 'alex',
           'phone': 'sffsfd', 'comments': 'sfdsdfs'})

print(max(int(value['id']) for value in lst))
