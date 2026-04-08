function solve(input) {
    return input
        .map(([width, height]) => ({
            width,
            height,
            area() { return this.width * this.height; },
            compareTo(other) {
                const areaDiff = this.area() - other.area();
                if (areaDiff !== 0) return areaDiff;
                return this.width - other.width;
            }
        }))
        .sort((a, b) => b.compareTo(a));
}
