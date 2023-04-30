function solve(numbers) {
    numbers = numbers.map(x => parseInt(x));

    console.log(numbers[0] + numbers[numbers.length - 1]);
}

solve(['20', '30', '40']);