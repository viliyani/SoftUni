function solve(numbers) {
    let result = [];

    let getMinNumber = () => {
        numbers.sort((a, b) => a - b);
        let minNumber = numbers[0];
        numbers = numbers.filter(x => x != minNumber);
        return minNumber;
    };

    result.push(getMinNumber(numbers));
    result.push(getMinNumber(numbers));

    console.log(result.join(' '));
}

solve([30, 15, 50, 5]);
solve([3, 0, 10, 4, 7, 3]);