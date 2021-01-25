function solve(input) {
    let phoneBook = {};

    for (const line of input) {
        let [name, phone] = line.split(' ');

        phoneBook[name] = phone;
    }

    Object.keys(phoneBook).forEach(x=>console.log(`${x} -> ${phoneBook[x]}`));
}

solve(['Tim 0834212554',
'Peter 0877547887',
'Bill 0896543112',
'Tim 0876566344']
);