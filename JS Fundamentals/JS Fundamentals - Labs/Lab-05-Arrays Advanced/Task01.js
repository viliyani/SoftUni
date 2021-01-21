function calculateSum(arr) {
    let first = Number(arr[0]);
    let last = Number(arr[arr.length - 1]);

    let result = first + last;

    return result;
}

let result = calculateSum(['10', '20', '30']);
console.log(result);