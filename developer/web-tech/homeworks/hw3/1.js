Math.round

function celsioumConverter()
{
    let celsium = Number.parseFloat(prompt('Введите температуру в градусах Цельсия'));
    alert(`Цельсия: ${celsium}\nФаренгейт: ${Math.round((1.8 * celsium + 32)*100)/100}`)
}