function calculate(numOne, numTwo, operator) {
    if (operator == "multiply") {
        return numOne * numTwo;
    } else if (operator == "divide") {
        return numOne / numTwo;
    } else if (operator == "add") {
        return numOne + numTwo;
    } else if (operator == "subtract") {
        return numOne - numTwo;
    }
}

console.log(calculate(3, 4, "multiply"));