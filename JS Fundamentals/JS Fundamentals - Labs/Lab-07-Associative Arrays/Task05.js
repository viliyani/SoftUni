function solve(input) {
    let map = new Map();

    let neighborhoods = input.shift().split(', ');

    for (const item of neighborhoods) {
        map.set(item, []);
    }

    for (const line of input) {
        let [neighborhood, person] = line.split(' - ');

        if (map.has(neighborhood)) {
            let newNames = map.get(neighborhood);
            newNames.push(person);
            map.set(neighborhood, newNames);
        }
    }

    let entries = Array.from(map.entries()).sort((a, b) => b[1].length - a[1].length);

    for (const kvp of entries) {
        console.log(`${kvp[0]}: ${kvp[1].length}`);
        if (kvp[1].length > 0) {
            for (const person of kvp[1]) {
                console.log(`--${person}`);
            }
        }
    }
}

solve(['Abbey Street, Herald Street, Bright Mews',
    'Bright Mews - Garry',
    'Bright Mews - Andrea',
    'Invalid Street - Tommy',
    'Abbey Street - Billy']
);