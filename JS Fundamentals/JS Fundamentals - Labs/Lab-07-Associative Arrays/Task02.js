function solve(input) {
    let storage = new Map();

    for (const line of input) {
        let [product, quantity] = line.split(' ');

        quantity = Number(quantity);

        if (storage.has(product)) {
            quantity += storage.get(product);
        }
        
        storage.set(product, quantity);
    }

    for (const kvp of storage) {
        console.log(`${kvp[0]} -> ${kvp[1]}`);
    }
}

solve(['tomatoes 10',
    'coffee 5',
    'olives 100',
    'coffee 40']
);