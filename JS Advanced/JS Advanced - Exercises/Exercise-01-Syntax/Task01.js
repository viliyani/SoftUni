function buyFruit(fruit, weightGrams, pricePerKg) {
    const weightKg = (weightGrams / 1000).toFixed(2);
    const money = (weightGrams / 1000 * pricePerKg).toFixed(2);
    console.log(`I need $${money} to buy ${weightKg} kilograms ${fruit}.`);
}
