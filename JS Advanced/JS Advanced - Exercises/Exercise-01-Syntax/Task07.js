function checkPoints([x1, y1, x2, y2]) {
    const dist = (ax, ay, bx, by) => Math.sqrt((bx - ax) ** 2 + (by - ay) ** 2);
    const check = (ax, ay, bx, by) => {
        const d = dist(ax, ay, bx, by);
        const valid = Number.isInteger(d) ? 'valid' : 'invalid';
        console.log(`{${ax}, ${ay}} to {${bx}, ${by}} is ${valid}`);
    };

    check(x1, y1, 0, 0);
    check(x2, y2, 0, 0);
    check(x1, y1, x2, y2);
}
