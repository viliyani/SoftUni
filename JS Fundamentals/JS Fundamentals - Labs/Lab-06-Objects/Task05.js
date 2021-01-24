function solve(arr) {
    class Cat {
        constructor(name, age) {
            this.name = name;
            this.age = age;
        }

        meow() {
            console.log(`${this.name}, age ${this.age} says Meow`);
        }
    }

    let cats = [];

    for (let i = 0; i < arr.length; i++) {
        let [name, ageText] = arr[i].split(' ');

        let cat = new Cat(name, Number(ageText));
        cats.push(cat);
    }

    cats.forEach(x => x.meow());
}

solve(['Mellow 2', 'Tom 5']);
