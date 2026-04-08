const table = document.querySelector("table");
let selected = null;

table.addEventListener("click", function (e) {
    const row = e.target.closest("tr");

    if (!row || row.closest("thead")) {
        return;
    }

    if (row === selected) {
        row.removeAttribute("style");
        selected = null;
        return;
    }

    if (selected) {
        selected.removeAttribute("style");
    }

    row.style.backgroundColor = "#413f5e";
    selected = row;
});
