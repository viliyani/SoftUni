function deleteByEmail() {
    const value = document.querySelector('input[name="email"]').value;
    const rows = Array.from(document.querySelectorAll('tbody tr'));
    let isDeleted = false;
    
    for (const row of rows) {
        const emailCell = row.children[1];
        if (emailCell.textContent === value) {
            row.remove();
            isDeleted = true;
            break;
        }
    }

    const resultElement = document.getElementById('result');
    if (isDeleted) {
        resultElement.textContent = 'Deleted.';
    } else {
        resultElement.textContent = 'Not found.';
    }
}