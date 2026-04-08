class List {
    constructor() {
        this._data = [];
        this.size = 0;
    }

    add(element) {
        this._data.push(element);
        this._data.sort((a, b) => a - b);
        this.size++;
        return this;
    }

    remove(index) {
        if (index < 0 || index >= this.size) return this;
        this._data.splice(index, 1);
        this.size--;
        return this;
    }

    get(index) {
        if (index < 0 || index >= this.size) return undefined;
        return this._data[index];
    }
}
