function jsonTable(input) {
    function escapeHtml(value) {
        return String(value)
            .replace(/&/g, '&amp;')
            .replace(/</g, '&lt;')
            .replace(/>/g, '&gt;')
            .replace(/"/g, '&quot;')
            .replace(/'/g, '&#39;');
    }

    let html = '<table>\n';

    for (const line of input) {
        const { name, position, salary } = JSON.parse(line);
        html += '\t<tr>\n';
        html += `\t\t<td>${escapeHtml(name)}</td>\n`;
        html += `\t\t<td>${escapeHtml(position)}</td>\n`;
        html += `\t\t<td>${escapeHtml(salary)}</td>\n`;
        html += '\t</tr>\n';
    }

    html += '</table>';
    return html;
}
