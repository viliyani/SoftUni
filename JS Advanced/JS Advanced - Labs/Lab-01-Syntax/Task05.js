function solve(...input) {
    const a = Number(input[0]);
    const b = Number(input[1]);
    const op = input[2];
    let result = 0;

    switch (op) {
        case '+':  result = a + b;  break;
        case '-':  result = a - b;  break;
        case '*':  result = a * b;  break;
        case '/':  result = a / b;  break;
        case '%':  result = a % b;  break;
        case '**': result = a ** b; break;
        default:   console.log('Unknown operator'); return;
    }

    console.log(result);
}