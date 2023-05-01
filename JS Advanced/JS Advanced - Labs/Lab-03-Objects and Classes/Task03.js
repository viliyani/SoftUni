function solve(input) {
    let result = {};

    input.forEach(row => {
        let [townName, townPopulation] = row.split(' <-> ');

        if (result.hasOwnProperty(townName)) {
            result[townName] += townPopulation;
        } else {
            result[townName] = townPopulation;
        }

    });

    for (const city in result) {
        console.log(`${city} : ${result[city]}`);
    }
}

function solveSecondWay(input) {
    let data = input.reduce((a, row) => {
        let [name, population] = row.split(' <-> ');
        a[name] = (a[name] || 0) + parseInt(population);
        return a;
    }, {});

    let result = Object.entries(data)
        .map(x => `${x[0]} : ${x[1]}`)
        .join("\n");
    console.log(result);
}

solveSecondWay(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']);