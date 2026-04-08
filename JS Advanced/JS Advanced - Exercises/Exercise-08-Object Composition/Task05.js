(function () {
    String.prototype.ensureStart = function (str) {
        if (this.startsWith(str)) return this.toString();
        return str + this;
    };

    String.prototype.ensureEnd = function (str) {
        if (this.endsWith(str)) return this.toString();
        return this + str;
    };

    String.prototype.isEmpty = function () {
        return this.length === 0;
    };

    String.prototype.truncate = function (n) {
        if (this.length <= n) return this.toString();
        if (n < 4) return '.'.repeat(n);

        const limit = n - 3;
        const candidate = this.slice(0, limit);
        const lastSpace = candidate.lastIndexOf(' ');

        if (lastSpace !== -1) {
            return this.slice(0, lastSpace) + '...';
        }
        return candidate + '...';
    };

    String.format = function (str, ...params) {
        return str.replace(/\{(\d+)\}/g, (match, index) => {
            const i = parseInt(index);
            return i < params.length ? params[i] : match;
        });
    };
}());
