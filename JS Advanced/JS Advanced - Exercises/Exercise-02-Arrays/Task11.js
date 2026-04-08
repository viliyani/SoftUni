function spiralMatrix(rows, cols) {
    const matrix = Array.from({ length: rows }, () => Array(cols).fill(0));

    const directions = [[0, 1], [1, 0], [0, -1], [-1, 0]];
    let dir = 0;
    let row = 0, col = 0;

    for (let num = 1; num <= rows * cols; num++) {
        matrix[row][col] = num;

        const [dr, dc] = directions[dir];
        const nextRow = row + dr;
        const nextCol = col + dc;

        if (
            nextRow < 0 || nextRow >= rows ||
            nextCol < 0 || nextCol >= cols ||
            matrix[nextRow][nextCol] !== 0
        ) {
            dir = (dir + 1) % 4;
        }

        row += directions[dir][0];
        col += directions[dir][1];
    }

    console.log(matrix.map(r => r.join(' ')).join('\n'));
}
