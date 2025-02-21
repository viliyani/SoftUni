function solve(input, n) {
    return input.filter((_, idx) => idx % n === 0);
}

console.log(solve(['5', '20', '31', '4', '20'], 2));
