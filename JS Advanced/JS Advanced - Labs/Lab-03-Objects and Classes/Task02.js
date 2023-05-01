function solve(input) {
    let result = {};

    for (let i = 0; i < input.length; i += 2) {
        let townName = input[i];
        let townIncome = parseInt(input[i + 1]);

        if (!result.hasOwnProperty(townName)) {
            result[townName] = townIncome;
        } else {
            result[townName] += townIncome;
        }
    }

    console.log(JSON.stringify(result));
}

solve(['Sofia','20','Varna','3','Sofia','5','Varna','4']);