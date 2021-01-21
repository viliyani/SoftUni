function solve(numbers) {
    console.log(
        numbers
            .filter(n => n % 2 != 0)
            .map(n => n * 2)
            .sort((a, b) => a - b)
            .join(' ')
    );
}

solve([3, 0, 10, 4, 7, 3]);
