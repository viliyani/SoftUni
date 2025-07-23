function sumTable () {
    const table = document.querySelector('table');
    const rows = Array.from(table.querySelectorAll('tr')).slice(1, -1);
    let sum = rows.reduce((acc, row) => {
        const cell = row.querySelector('td:last-child');
        acc += Number(cell.textContent);
        return acc;
    }, 0);

    document.getElementById('sum').textContent = sum;
}