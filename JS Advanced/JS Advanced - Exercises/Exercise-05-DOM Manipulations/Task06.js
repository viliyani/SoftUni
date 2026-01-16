function solve() {
    const [inputArea, outputArea] = Array.from(document.querySelectorAll('textarea'));
    const [generateBtn, buyBtn] = Array.from(document.querySelectorAll('button'));
    const tableBody = document.querySelector('tbody');
    const furniture = [];
    
    generateBtn.addEventListener('click', onGenerateRecord);
    buyBtn.addEventListener('click', onBuy);

    function onGenerateCell(type, value) {
        const td = document.createElement('td');
        const childElement = document.createElement(type);
        td.appendChild(childElement);
        
        if (type === 'img') {
            childElement.src = value;
        } else if (type === 'p') {
            childElement.textContent = value;
        } else if (type === 'input') {
            childElement.type = 'checkbox';
        }

        return td;
    }

    function onGenerateRecord() {
        const items = JSON.parse(inputArea.value);

        for (const item of items) {
            const row = document.createElement('tr');

            row.appendChild(onGenerateCell('img', item.img));
            row.appendChild(onGenerateCell('p', item.name));
            row.appendChild(onGenerateCell('p', item.price));
            row.appendChild(onGenerateCell('p', item.decFactor));
            row.appendChild(onGenerateCell('input'));
            
            tableBody.appendChild(row);
        }

        inputArea.value = '';
    }
    
    function onBuy() {
        const boughtItems = []; 
        let totalPrice = 0;
        let totalDecFactor = 0;
        const rows = Array.from(tableBody.querySelectorAll('tr'));
        for (const row of rows) {
            const isChecked = row.querySelector('input[type="checkbox"]').checked;
            if (isChecked) {
                const cells = row.querySelectorAll('td');
                const name = cells[1].textContent;
                const price = Number(cells[2].textContent);
                const decFactor = Number(cells[3].textContent);
                
                boughtItems.push(name);
                totalPrice += price;
                totalDecFactor += decFactor;
            }
        }

        const avgDecFactor = boughtItems.length > 0 ? totalDecFactor / boughtItems.length : 0;
        
        outputArea.value = `Bought furniture: ${boughtItems.join(', ')}
Total price: ${totalPrice.toFixed(2)}
Average decoration factor: ${avgDecFactor}`;
    }
}