function solve(n, k) {
    let result = [1];

    for (let i = 1; i < n; i++) {
        let lastKElementsSum = result.slice(-k).reduce((a, x) => a += x, 0);
        result.push(lastKElementsSum);
    }

    console.log(result.join(' '));
}

solve(6, 3);
solve(8, 2);