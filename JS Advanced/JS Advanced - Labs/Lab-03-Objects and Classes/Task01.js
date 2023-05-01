function solve(input) {
    let result = [];

    let propertyNames = extractValuesFromRow(input.shift());

    input.forEach(row => {
        let currentValues = extractValuesFromRow(row);

        let newObject = {};

        for (let i = 0; i < propertyNames.length; i++) {
            newObject[propertyNames[i]] = currentValues[i];
        }

        result.push(newObject);
    });

    console.log(JSON.stringify(result));

}

function extractValuesFromRow(row) {
    return row
        .split('|')
        .filter(x => x.length > 0)
        .map(x => x.trim());
}

solve(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']);
