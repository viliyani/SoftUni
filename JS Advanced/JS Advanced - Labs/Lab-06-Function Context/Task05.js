function Spy(target, method) {
    const spy = { count: 0 };
    const original = target[method];

    target[method] = function (...args) {
        spy.count++;
        return original.apply(this, args);
    };

    return spy;
}