function solve(arr) {
    let condensed = [];
    condensed.length = arr.length - 1;

    while (arr.length > 1) {
        for (let i = 0; i < arr.length - 1; i++) {
            condensed[i] = arr[i] + arr[i + 1];
            arr[i] = condensed[i];
        }
        arr.length--;
    }

    console.log(arr[0]);
}

solve([2, 10, 3]);
solve([5, 0, 4, 1, 2]);