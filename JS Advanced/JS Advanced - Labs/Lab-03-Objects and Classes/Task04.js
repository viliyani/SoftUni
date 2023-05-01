function solve(input) {
    let data = JSON.parse(input);

    let result = '<table><tr>';

    let colNames = Object.keys(data[0]);

    colNames.forEach(name => result += `<th>${name}</th>`)

    result += '</tr>';

    data.forEach(item => {
        let elementForHtml = '<tr>'

        elementForHtml += Object.entries(item)
            .map(x => `<td>${x[1]}</td>`)
            .join('');
        
        elementForHtml += '</tr>';

        result += elementForHtml;
    });

    result += '</table>';
    console.log(result);
}

solve(['[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]']);