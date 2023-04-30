function solve(matrix) {
    let n = matrix.length;
    let result = 0;

    for (let row = 0; row < n; row++) {
        for (let col = 0; col < n; col++) {
            if (row < n - 1 && matrix[row][col] == matrix[row + 1][col]) {
                result += 1;
            }
            if (col < n - 1 && matrix[row][col] == matrix[row][col + 1]) {
                result += 1;
            }
        }
    }

    console.log(result);
}

solve([['2', '3', '4', '7', '0'],
['4', '0', '5', '3', '4'],
['2', '3', '5', '4', '2'],
['9', '8', '7', '5', '4']]);

solve([['test', 'yes', 'yo', 'ho'],
['well', 'done', 'yo', '6'],
['not', 'done', 'yet', '5']]);