// Запрашиваем имя 
function getName()
{
    let user_name = prompt('Введите Ваше имя:');
    grettings(user_name);
}
// Выводим приветсвтие
function grettings(name) {
    msg = 'Привет, ' + name;
    alert(msg); // выводи через всплывающее окно для проверки
    console.log(msg); // вывородим в консоль по заданию
};
    