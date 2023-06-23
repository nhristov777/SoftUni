function moneyForFruit(fruit, weightInGrams, pricePerKilo)
{
    let kilos = weightInGrams / 1000
    let price = kilos * pricePerKilo

    console.log(`I need $${price.toFixed(2)} to buy ${kilos.toFixed(2)} kilograms ${fruit}.`)
}