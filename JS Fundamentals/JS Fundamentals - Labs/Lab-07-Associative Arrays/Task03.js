function solve(input) {
    let map = new Map();

    const average = arr => arr.reduce((p, c) => p + c, 0) / arr.length;

    for (const line of input) {
        let tokens = line.split(' ');

        let name = tokens.shift();
        let grades = tokens.map(Number);

        if (map.has(name)) {
            grades = map.get(name).concat(grades);
        }

        map.set(name, grades);
    }

    let entries = Array.from(map.entries());

    let sortedEntries = entries.sort((a, b) => {
        return average(a[1]) - average(b[1]);
    });

    for (const kvp of sortedEntries) {
        console.log(`${kvp[0]}: ${kvp[1].join(', ')}`);
    }
}

solve(['Lilly 4 6 6 5',
    'Tim 5 6',
    'Tammy 2 4 3',
    'Tim 6 6']
);