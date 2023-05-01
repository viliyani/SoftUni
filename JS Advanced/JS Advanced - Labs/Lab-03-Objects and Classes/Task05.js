function solve(input) {
    let result = {};

    input.forEach(x => {
        let [town, product, price] = x.split(' | ');
        price = parseInt(price);

        if (!result.hasOwnProperty(product)) {
            result[product] = [];
        }

        if (result[product].some(x => x['town'] == town)) {
            result[product][town] = price;
        } else {
            result[product].push({'town': town, 'price': price});
        }
    });

    for (const product in result) {
        let sortedTowns = result[product].sort((a,b) => {
            if (a.price < b.price) {
                return -1;
            } else if (a.price > b.price) {
                return 1;
            } else if (a.price == b.price) {
                return 0;
            }
        });
        console.log(`${product} -> ${sortedTowns[0].price} (${sortedTowns[0].town})`)
    }
}

solve(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 5',
'Sample Town | Peach | 1',
'Sofia | Orange | 2',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10'])