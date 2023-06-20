// Запрашиваем имя 
function getName() {
    const userMame = prompt('Введите Ваше имя:');
    grettings(userName);
}
// Выводим приветсвтие
function grettings(name) {
    const msg = 'Привет, ' + name;
    alert(msg); // выводи через всплывающее окно для проверки
    console.log(msg); // вывородим в консоль по заданию
}

getName();