class Company {
    constructor() {
        this.departments = [];
    }

    addEmployee(username, salary, position, department) {
        if (!username || !position || !department || salary === undefined || salary === null || salary === "") {
            throw new Error("Invalid input!");
        }
        if (salary < 0) {
            throw new Error("Invalid input!");
        }

        let dept = this.departments.find(d => d.name === department);
        if (!dept) {
            dept = { name: department, employees: [] };
            this.departments.push(dept);
        }

        dept.employees.push({ name: username, salary, position });

        return `New employee is hired. Name: ${username}. Position: ${position}`;
    }

    bestDepartment() {
        let best = null;
        let bestAvg = -Infinity;

        for (const dept of this.departments) {
            const avg = dept.employees.reduce((sum, e) => sum + e.salary, 0) / dept.employees.length;
            if (avg > bestAvg) {
                bestAvg = avg;
                best = dept;
            }
        }

        const sorted = best.employees
            .slice()
            .sort((a, b) => b.salary - a.salary || a.name.localeCompare(b.name));

        const lines = sorted.map(e => `${e.name} ${e.salary} ${e.position}`).join("\n");

        return `Best Department is: ${best.name}\nAverage salary: ${bestAvg.toFixed(2)}\n${lines}`;
    }
}
