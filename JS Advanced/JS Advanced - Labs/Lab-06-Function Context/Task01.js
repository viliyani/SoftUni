function solve(area, vol, input) {
    return JSON.parse(input).map(figure => {
        const obj = { x: Number(figure.x), y: Number(figure.y), z: Number(figure.z) };
        return {
            area: Math.abs(area.call(obj)),
            volume: Math.abs(vol.call(obj))
        };
    });
}