function addItem() {
    const liItem = document.createElement('li');
    const inputElement = document.getElementById('newItemText');
    liItem.textContent = inputElement.value;
    document.getElementById('items').appendChild(liItem);
    inputElement.value = '';
}