function extractText() {
    const list = document.getElementById('items');
    const items = Array.from(list.children);
    const result = document.getElementById('result');
    result.value = items.map(item => item.textContent).join('\n');
}