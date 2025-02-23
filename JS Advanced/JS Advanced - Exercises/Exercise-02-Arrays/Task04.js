function solve(input, rotationsNum) {
    for (let i = 0; i < rotationsNum; i++) {
        input.unshift(input.pop());
    }

    return input.join(' ');
}

console.log(solve(['Banana', 'Orange', 'Coconut', 'Apple'], 15));
