function cappyJuice(input) {
    const quantities = {};
    const bottles = {};
    const order = [];

    for (const line of input) {
        const [juice, qty] = line.split(' => ');
        const quantity = Number(qty);

        quantities[juice] = (quantities[juice] || 0) + quantity;

        if (quantities[juice] >= 1000) {
            const newBottles = Math.floor(quantities[juice] / 1000);
            quantities[juice] %= 1000;

            if (!bottles[juice]) {
                bottles[juice] = 0;
                order.push(juice);
            }
            bottles[juice] += newBottles;
        }
    }

    for (const juice of order) {
        console.log(`${juice} => ${bottles[juice]}`);
    }
}
