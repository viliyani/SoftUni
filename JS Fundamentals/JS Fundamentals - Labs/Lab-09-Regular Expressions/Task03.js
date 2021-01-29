function solve(input) {
    let pattern = /\b(?<day>\d{2})([.\-\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b/g;

    let valid = pattern.exec(input);
    while (valid !== null) {
        let day = valid.groups.day;
        let month = valid.groups.month;
        let year = valid.groups.year;

        console.log(`Day: ${day}, Month: ${month}, Year: ${year}`);
        
        valid = pattern.exec(input);
    }
}

solve("13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016");