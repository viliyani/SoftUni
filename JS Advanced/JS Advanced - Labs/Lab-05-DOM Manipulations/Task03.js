function addItem() {
    const inputElement = document.getElementById('newItemText');

    const aElement = document.createElement('a');
    aElement.href = '#';
    aElement.textContent = '[Delete]';
    aElement.addEventListener('click', deleteItem);

    const liElement = document.createElement('li');
    liElement.textContent = inputElement.value + ' ';
    liElement.appendChild(aElement);

    const ulElement = document.getElementById('items');
    ulElement.appendChild(liElement);

    inputElement.value = '';

    function deleteItem(event) {
        event.target.parentElement.remove();
    }
}