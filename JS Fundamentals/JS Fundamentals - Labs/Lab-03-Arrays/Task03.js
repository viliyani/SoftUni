function solve(n, arr) {
    let numbers = [];

    for (let i = n - 1; i >= 0; i--) {
        numbers.push(arr[i]);
    }

    console.log(numbers.join(' '));
}

solve(3, [10, 20, 30, 40, 50]);