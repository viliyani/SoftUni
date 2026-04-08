function add(num) {
    let sum = num;

    function inner(n) {
        sum += n;
        return inner;
    }

    inner.valueOf = function () { return sum; };
    inner.toString = function () { return String(sum); };

    return inner;
}
