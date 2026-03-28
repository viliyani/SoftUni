function solve() {
    const selectMenuTo = document.getElementById('selectMenuTo');
    document.querySelector('button').addEventListener('click', convertNumbers);

    initForm();

    const converters = {
        binary: x => x.toString(2),
        hexadecimal: x => x.toString(16).toUpperCase()
    };

    function convertNumbers() {
        const number = Number(document.getElementById('input').value);
        if (isNaN(number)) return;
        document.getElementById('result').value = converters[selectMenuTo.value](number);
    }

    function createOption(value, text) {
        const option = document.createElement('option');
        option.value = value;
        option.text = text;
        return option;
    }

    function initForm() {
        const options = [
            { value: 'binary', text: 'Binary' },
            { value: 'hexadecimal', text: 'Hexadecimal' }
        ];
        options.forEach(({ value, text }) => selectMenuTo.appendChild(createOption(value, text)));
    }
}