function solve(from, to) {
    let sum = 0;

    let result = "";

    for (let i = from; i <= to; i++) {
        result = result + i + " ";
        sum += i;
    }
    
    console.log(result);
    console.log("Sum: " + sum);
}