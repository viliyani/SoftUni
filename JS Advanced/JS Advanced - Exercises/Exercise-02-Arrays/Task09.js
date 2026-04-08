function diagonalAttack(input) {
    const matrix = input.map(row => row.split(' ').map(Number));
    const n = matrix.length;

    let mainDiagSum = 0;
    let antiDiagSum = 0;

    for (let i = 0; i < n; i++) {
        mainDiagSum += matrix[i][i];
        antiDiagSum += matrix[i][n - 1 - i];
    }

    if (mainDiagSum === antiDiagSum) {
        for (let i = 0; i < n; i++) {
            for (let j = 0; j < n; j++) {
                if (i !== j && i + j !== n - 1) {
                    matrix[i][j] = mainDiagSum;
                }
            }
        }
    }

    console.log(matrix.map(row => row.join(' ')).join('\n'));
}
