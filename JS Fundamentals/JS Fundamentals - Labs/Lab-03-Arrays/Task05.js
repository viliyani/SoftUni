function sumEvenNumbers(arr) {
    let sum = 0;

    arr = arr.filter(x => x % 2 == 0);

    for (let num of arr) {
        sum += Number(num);
    }

    console.log(sum);
}

sumEvenNumbers(['1', '2', '3', '4', '5', '6']);