function solve(number, precision) {

    let result = "";

    if (precision >= 0 && precision <= 15) {
        result = parseFloat(number.toFixed(precision));
    } else {
        result = parseFloat(number.toFixed(15));
    }
    console.log(result);
}