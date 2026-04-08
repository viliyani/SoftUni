function gcd(a, b) {
    while (b !== 0) {
        [a, b] = [b, a % b];
    }
    console.log(a);
}
