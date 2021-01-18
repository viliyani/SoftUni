function solve(numOne, numTwo, numThree) {
    if ((numOne > 0 && numTwo > 0 && numThree > 0) ||
        (numOne < 0 && numTwo < 0 && numThree > 0) ||
        (numOne < 0 && numTwo > 0 && numThree < 0) ||
        (numOne > 0 && numTwo < 0 && numThree < 0) ||
        numOne === 0 || numTwo === 0 || numThree === 0) {
        return "Positive";
    } else if ((numOne < 0 && numTwo < 0 && numThree < 0) ||
        (numOne < 0 && numTwo > 0 && numThree > 0) ||
        (numOne > 0 && numTwo < 0 && numThree > 0) ||
        (numOne > 0 && numTwo > 0 && numThree < 0)) {
        return "Negative";
    }
}