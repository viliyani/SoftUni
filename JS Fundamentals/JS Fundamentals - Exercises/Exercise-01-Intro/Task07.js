function solve(num) {
    for (let i = 1; i <= num; i++) {
        let result = "";
        result += i + " ";
        console.log(result.repeat(i));
    }
}