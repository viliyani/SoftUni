function solve(input) {
    let pattern = /\+359([ \-])2\1\d{3}\1\d{4}\b/g;
    let validNumbers = [];
    
    let valid = pattern.exec(input);

    while (valid !== null) {
        validNumbers.push(valid[0]);
        valid = pattern.exec(input);
    }

    console.log(validNumbers.join(", "));
}

solve("+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222");