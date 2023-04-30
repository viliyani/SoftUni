function solve(matrix) {
    let n = matrix.length;
    let sumDiagonalOne = 0;

    for (let i = 0; i < n; i++) {
        sumDiagonalOne += matrix[i][i];
    }

    let sumDiagonalTwo = 0;

    for (let i = 0; i < n; i++) {
        sumDiagonalTwo += matrix[i][n-i-1];
    }

    console.log(sumDiagonalOne + ' ' + sumDiagonalTwo);
}

solve([[20, 40], [10, 60]]);
solve([[3, 5, 17], [-1, 7, 14], [1, -8, 89]]);