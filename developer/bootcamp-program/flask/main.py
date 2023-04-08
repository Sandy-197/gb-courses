from flask import Flask

app = Flask(__name__)

@app.route('/')
def main():
    return 'Hello, world<br><a href="/index">Вторая страница</a>'

@app.route('/index/<x>/<y>')
def index(x,y):
    return f'Результат: {int(x)+int(y)}'

if __name__ == '__main__':
    app.run()