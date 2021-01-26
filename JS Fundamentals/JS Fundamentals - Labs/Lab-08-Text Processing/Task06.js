function solve(input) {
    let words = input.split(' ');

    let iterator = {
        next: function () {
            let isDone = words.length === 0;
            let currentWord = words.shift();

            return {
                value: currentWord,
                done: isDone
            };
        }
    };

    let next = iterator.next();

    while (!next.done) {
        console.log(next.value);
        next = iterator.next();
    }

}

solve("Et cillum do voluptate cillum ut cupidatat aliqua.");