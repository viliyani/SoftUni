function solve() {
    const toConvention = (text, predicate) => text
        .toLowerCase()
        .split(/\s+/gm)
        .map(predicate)
        .join('');

    const cases = {
        'Pascal Case': text => toConvention(text, w => w.charAt(0).toUpperCase() + w.slice(1)),
        'Camel Case': text => toConvention(text, (w, i) => i === 0 ? w : w.charAt(0).toUpperCase() + w.slice(1)),
        default: 'Error!'
    };

    const text = document.getElementById('text').value;
    const convention = document.getElementById('naming-convention').value;

    document.getElementById('result').textContent =
        cases[convention]
            ? cases[convention](text)
            : cases['default'];
}