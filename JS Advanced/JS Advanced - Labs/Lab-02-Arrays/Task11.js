function solve(arr) {
    let count = 0;

    for (let row = 0; row < arr.length; row++) {
        for (let col = 0; col < arr[row].length; col++) {
            if (col + 1 < arr[row].length && arr[row][col] === arr[row][col + 1]) {
                count++;
            }
            if (row + 1 < arr.length && arr[row][col] === arr[row + 1][col]) {
                count++;
            }
        }
    }

    return count;
}

solve(
    [['2', '3', '4', '7', '0'],
    ['4', '0', '5', '3', '4'],
    ['2', '3', '5', '4', '2'],
    ['9', '8', '7', '5', '4']]
);

solve([['test', 'yes', 'yo', 'ho'],
['well', 'done', 'yo', '6'],
['not', 'done', 'yet', '5']]);