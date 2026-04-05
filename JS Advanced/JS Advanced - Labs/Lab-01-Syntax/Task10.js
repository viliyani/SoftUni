function solve(input) {
    console.log(input.reduce((acc, n) => acc + n, 0));
    console.log(input.reduce((acc, n) => acc + 1 / n, 0));
    console.log(input.join(''));
}