function magicMatrix(matrix) {
    const target = matrix[0].reduce((sum, n) => sum + n, 0);

    for (let row of matrix) {
        if (row.reduce((sum, n) => sum + n, 0) !== target) {
            return false;
        }
    }

    for (let col = 0; col < matrix[0].length; col++) {
        let colSum = 0;
        for (let row = 0; row < matrix.length; row++) {
            colSum += matrix[row][col];
        }
        if (colSum !== target) {
            return false;
        }
    }

    return true;
}
