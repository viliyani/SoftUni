function solution() {
    class Employee {
        constructor(name, age) {
            if (new.target === Employee) {
                throw new Error('Cannot instantiate abstract class Employee.');
            }
            this.name = name;
            this.age = age;
            this.salary = 0;
            this.tasks = [];
        }

        work() {
            const task = this.tasks.shift();
            this.tasks.push(task);
            console.log(`${this.name} ${task}`);
        }

        getSalary() {
            return this.salary;
        }

        collectSalary() {
            console.log(`${this.name} received ${this.getSalary()} this month.`);
        }
    }

    class Junior extends Employee {
        constructor(name, age) {
            super(name, age);
            this.tasks.push('is working on a simple task.');
        }
    }

    class Senior extends Employee {
        constructor(name, age) {
            super(name, age);
            this.tasks.push(
                'is working on a complicated task.',
                'is taking time off work.'
            );
        }
    }

    class Manager extends Employee {
        constructor(name, age) {
            super(name, age);
            this.dividend = 0;
            this.tasks.push(
                'is supervising junior workers.',
                'scheduled a meeting.',
                'is preparing a quarterly report.'
            );
        }

        getSalary() {
            return this.salary + this.dividend;
        }
    }

    return { Junior, Senior, Manager };
}
