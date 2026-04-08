function cookingOperations(start, ...ops) {
    const operations = {
        chop: n => n / 2,
        dice: n => Math.sqrt(n),
        spice: n => n + 1,
        bake: n => n * 3,
        fillet: n => n * 0.8
    };

    let num = Number(start);
    for (const op of ops) {
        num = operations[op](num);
        console.log(num);
    }
}
