function getFibonator() {
    let prev = 0;
    let curr = 1;

    return function () {
        const result = curr;
        [prev, curr] = [curr, prev + curr];
        return result;
    };
}
