function solve() {
    let bugs = [];
    let nextId = 0;
    let outputSelector = null;
    let sortMethod = 'ID';

    function render() {
        if (!outputSelector) return;
        const container = document.querySelector(outputSelector);
        if (!container) return;

        const sorted = bugs.slice().sort((a, b) => {
            if (sortMethod === 'author') return a.author.localeCompare(b.author);
            if (sortMethod === 'severity') return a.severity - b.severity;
            return a.ID - b.ID;
        });

        container.innerHTML = sorted.map(bug => `
<div id="report_${bug.ID}" class="report">
  <div class="body">
    <p>${bug.description}</p>
  </div>
  <div class="title">
    <span class="author">Submitted by: ${bug.author}</span>
    <span class="status">${bug.status} | ${bug.severity}</span>
  </div>
</div>`).join('');
    }

    return {
        report(author, description, reproducible, severity) {
            bugs.push({ ID: nextId++, author, description, reproducible, severity, status: 'Open' });
            render();
        },
        setStatus(id, newStatus) {
            const bug = bugs.find(b => b.ID === id);
            if (bug) {
                bug.status = newStatus;
                render();
            }
        },
        remove(id) {
            bugs = bugs.filter(b => b.ID !== id);
            render();
        },
        sort(method) {
            sortMethod = method;
            render();
        },
        output(selector) {
            outputSelector = selector;
            render();
        }
    };
}
