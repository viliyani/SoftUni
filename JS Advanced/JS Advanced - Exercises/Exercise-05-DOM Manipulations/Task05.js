function solve() {
    const buttons = Array.from(document.querySelectorAll('button'));
    const textareas = Array.from(document.querySelectorAll('textarea'));

    buttons[0].addEventListener('click', encode);
    buttons[1].addEventListener('click', decode);
    
    function encode() {
        const input = textareas[0].value;
        let encoded = '';

        for (let i = 0; i < input.length; i++) {
            const charCode = input.charCodeAt(i);
            encoded += String.fromCharCode(charCode + 1);
        }

        textareas[1].value = encoded;
        textareas[0].value = '';
    }

    function decode() {
        const input = textareas[1].value;
        let decoded = '';
        
        for (let i = 0; i < input.length; i++) {
            const charCode = input.charCodeAt(i);
            decoded += String.fromCharCode(charCode - 1);
        }

        textareas[1].value = decoded;
    }
}