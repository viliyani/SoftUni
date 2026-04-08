function figures() {
    const CONVERSION = { 'cm': 1, 'mm': 10, 'm': 0.01 };

    class Figure {
        constructor() {
            this.units = 'cm';
        }

        changeUnits(units) {
            this.units = units;
        }

        get _factor() {
            return CONVERSION[this.units];
        }
    }

    class Circle extends Figure {
        constructor(radius, units = 'cm') {
            super();
            this._radius = radius;
            this.changeUnits(units);
        }

        get area() {
            const r = this._radius * this._factor;
            return Math.PI * r * r;
        }

        toString() {
            const r = this._radius * this._factor;
            return `Figures units: ${this.units} Area: ${this.area} - radius: ${r}`;
        }
    }

    class Rectangle extends Figure {
        constructor(width, height, units = 'cm') {
            super();
            this._width = width;
            this._height = height;
            this.changeUnits(units);
        }

        get area() {
            return (this._width * this._factor) * (this._height * this._factor);
        }

        toString() {
            const w = this._width * this._factor;
            const h = this._height * this._factor;
            return `Figures units: ${this.units} Area: ${this.area} - width: ${w}, height: ${h}`;
        }
    }

    return { Figure, Circle, Rectangle };
}
