function solution() {
    const stock = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    };

    const recipes = {
        apple:    [['carbohydrate', 1], ['flavour', 2]],
        lemonade: [['carbohydrate', 10], ['flavour', 20]],
        burger:   [['carbohydrate', 5], ['fat', 7], ['flavour', 3]],
        eggs:     [['protein', 5], ['fat', 1], ['flavour', 1]],
        turkey:   [['protein', 10], ['carbohydrate', 10], ['fat', 10], ['flavour', 10]]
    };

    return function (command) {
        const parts = command.split(' ');
        const action = parts[0];

        if (action === 'restock') {
            const [, ingredient, qty] = parts;
            stock[ingredient] += Number(qty);
            return 'Success';
        }

        if (action === 'prepare') {
            const [, meal, qty] = parts;
            const quantity = Number(qty);
            const ingredients = recipes[meal.toLowerCase()];

            for (const [ingredient, amount] of ingredients) {
                if (stock[ingredient] < amount * quantity) {
                    return `Error: not enough ${ingredient} in stock`;
                }
            }

            for (const [ingredient, amount] of ingredients) {
                stock[ingredient] -= amount * quantity;
            }
            return 'Success';
        }

        if (action === 'report') {
            return `protein=${stock.protein} carbohydrate=${stock.carbohydrate} fat=${stock.fat} flavour=${stock.flavour}`;
        }
    };
}
