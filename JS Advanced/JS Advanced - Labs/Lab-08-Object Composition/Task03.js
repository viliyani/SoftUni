function result(input) {
    const objects = JSON.parse(input);
    return Object.assign({}, ...objects);
}

console.log(result(`[{"canMove": true},{"canMove":true, "doors": 4},{"capacity": 5}]`));
console.log(result(`[{"canFly": true},{"canMove":true, "doors": 4},{"capacity": 255},{"canFly":true, "canLand": true}]`));
