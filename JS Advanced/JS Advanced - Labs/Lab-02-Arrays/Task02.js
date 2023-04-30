function solve(numbers) {
    let result = numbers
        .filter((x, i) => i % 2 == 0)
        .map(Number)
        .join(' ');

    console.log(result);
}

solve(['20', '30', '40']);
solve(['5', '10']);