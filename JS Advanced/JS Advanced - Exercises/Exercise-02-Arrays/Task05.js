function solve(input) {
    return input.reduce((a, v) => {
        if (a.length == 0 || v >= a[a.length - 1]) {
            a.push(v);
        }
        return a;
    }, []);
}

console.log(solve([1, 3, 8, 4, 10, 12, 3, 2, 24]));
