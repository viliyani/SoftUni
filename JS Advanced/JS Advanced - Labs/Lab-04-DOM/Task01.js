function editElement(element, searchValue, replaceValue) {
    while (element.innerText.includes(searchValue)) {
        element.innerText = element.innerText.replace(searchValue, replaceValue);
    }
}