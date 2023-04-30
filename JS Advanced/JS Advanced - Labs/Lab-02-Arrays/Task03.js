function solve(numbers) {
    let result = [];

    numbers.forEach(x => x < 0 ? result.unshift(x) : result.push(x));

    result.forEach(x => console.log(x));
}

solve([7, -2, 8, 9]);