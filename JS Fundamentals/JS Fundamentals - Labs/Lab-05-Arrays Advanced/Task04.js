function solve(n, k) {
    let arr = [];

    let calcSum = (input) => {
        let sum = 0;

        for (let i = 0; i < input.length; i++) {
            sum += input[i];
        }

        return Number(sum);
    };

    arr.push(1);
    arr.push(1);
    arr.push(2);

    for (let i = 3; i < n; i++) {
        arr.push(calcSum(arr.slice(arr.length - k, arr.length)));
    }

    console.log(arr.join(' '));
}

solve(8, 2);