function solve(input) {
    let [result, num] = [[], 0];

    input.forEach(command => {
        num++;
        if (command == 'add') {
            result.push(num);
        } else {
            result.pop();
        }
    });

    console.log(result.length > 0 ? result.join('\n') : 'Empty');
}

solve(['add', 'add', 'remove', 'add', 'add']);
