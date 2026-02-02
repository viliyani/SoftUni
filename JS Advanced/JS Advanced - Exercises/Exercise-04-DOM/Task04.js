function solve() {
    const items = Array.from(document.getElementsByTagName('li'));
    const searchedText = document.getElementById('searchText').value;
    let count = 0;

    const matches = items.map(
        el => {
            el.style.fontWeight = 'normal';
            el.style.textDecoration = '';

            if (el.textContent.includes(searchedText) && searchedText) {
                count++;
                el.style.fontWeight = 'bold';
                el.style.textDecoration = 'underline';
            }

            return el;
        }
    );

    document.getElementById('result').textContent = `${count} matches found`;
}