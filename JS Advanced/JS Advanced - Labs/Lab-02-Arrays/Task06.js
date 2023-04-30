function solve(numbers) {
    let firstMinNumber = Math.min(...numbers);
    let indexOfFirstMinNumber = numbers.indexOf(firstMinNumber);
    numbers.splice(indexOfFirstMinNumber, 1);
    let secondMinNumber = Math.min(...numbers);

    console.log(firstMinNumber + ' ' + secondMinNumber);
}

solve([30, 15, 50, 5]);
solve([3, 0, 10, 4, 7, 3]);