function solve(order) {
    const engines = [
        { power: 90, volume: 1800 },
        { power: 120, volume: 2400 },
        { power: 200, volume: 3500 }
    ];

    const engine = engines.find(e => e.power >= order.power);

    const carriage = { type: order.carriage, color: order.color };

    let wheelSize = order.wheelsize;
    if (wheelSize % 2 === 0) wheelSize--;

    return {
        model: order.model,
        engine,
        carriage,
        wheels: [wheelSize, wheelSize, wheelSize, wheelSize]
    };
}
