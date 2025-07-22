function colorize() {
    Array.from(document.querySelectorAll('tr:nth-child(2n)'))
        .forEach(tr => tr.style.backgroundColor = 'teal');
}