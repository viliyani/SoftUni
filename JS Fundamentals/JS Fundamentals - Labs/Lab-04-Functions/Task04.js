function calculatePrice(product, qty) {
    let total = 0.00;
    let price = 0.00;

    if (product == "coffee") {
        price = 1.50;
    } else if (product == "water") {
        price = 1.00;
    } else if (product == "coke") {
        price = 1.40;
    } else if (product == "snacks") {
        price = 2.00;
    }

    return (price * qty).toFixed(2);
}

let result = calculatePrice("water", 5);
console.log(result);