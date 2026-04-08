function starOrbits([width, height, x, y]) {
    const matrix = [];

    for (let row = 0; row < height; row++) {
        const rowArr = [];
        for (let col = 0; col < width; col++) {
            rowArr.push(Math.max(Math.abs(row - y), Math.abs(col - x)) + 1);
        }
        matrix.push(rowArr);
    }

    console.log(matrix.map(row => row.join(' ')).join('\n'));
}
