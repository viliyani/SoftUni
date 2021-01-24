function solve(input) {
    let cat = JSON.parse(input);

    for (let prop in cat) {
        console.log(`${prop}: ${cat[prop]}`);
    }
}

solve('{"name": "George", "age": 40, "town": "Sofia"}');