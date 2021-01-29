function solve(input) {
    let pattern = /\b[A-Z][a-z]+ [A-Z][a-z]+\b/g;
    let validNames = [];
    
    let valid = pattern.exec(input);

    while (valid !== null) {
        validNames.push(valid[0]);
        valid = pattern.exec(input);
    }

    console.log(validNames.join(" "));
}

solve('ivan ivanov, Ivan ivanov, Ivan Ivanov, ivan Ivanov, IVan Ivanov, Peter Petrov, Ivan IvAnov, Ivan	Ivanov');