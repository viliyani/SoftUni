function solution(number)
{
    let sum = number;

    return function(number) {
        return sum + number;
    }
}

let add5 = solution(5);
console.log(add5(2));
console.log(add5(3));