function solve() {
    const list = {
        _data: [],
        size: 0,
        add(element) {
            this._data.push(element);
            this._data.sort((a, b) => a - b);
            this.size++;
        },
        remove(index) {
            if (index < 0 || index >= this.size) return;
            this._data.splice(index, 1);
            this.size--;
        },
        get(index) {
            if (index < 0 || index >= this.size) return;
            return this._data[index];
        }
    };
    return list;
}
