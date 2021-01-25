function solve(input) {
    let map = new Map();

    for (const word of input) {
        let cnt = 1;

        if (map.has(word)) {
            cnt += map.get(word);
        }

        map.set(word, cnt);
    }

    let entries = Array.from(map.entries())
        .sort((a, b) => {
            return b[1] - a[1];
        });

    for (const kvp of entries) {
        console.log(`${kvp[0]} -> ${kvp[1]} times`);
    }
}

solve(["Here", "is", "the", "first", "sentence", "Here", "is", "another", "sentence", "And", "finally", "the", "third", "sentence"]);