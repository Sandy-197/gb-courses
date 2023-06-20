function celsioumConverter() {
    const celsium = Number.parseFloat(prompt('Введите температуру в градусах Цельсия'));
    const faringate = 1.8 * celsium + 32;
    alert(`Цельсия: ${celsium}\nФаренгейт: ${faringate.toFixed(2)}`)
}

celsioumConverter();