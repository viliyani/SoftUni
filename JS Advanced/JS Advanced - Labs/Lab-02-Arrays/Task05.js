function solve(numbers) {
    let result = numbers
        .filter((x, i) => i % 2 != 0)
        .map(x => x * 2)
        .reverse()
        .join(' ');

    console.log(result);
}

solve([10, 15, 20, 25]);