function solve(arr) {
    let maxNumbersFromRows = arr.map(row => Math.max(...row));
    let maxNumber = Math.max(...maxNumbersFromRows);

    console.log(maxNumber);
}

solve([[20, 50, 10], [8, 33, 145]]);