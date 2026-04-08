function buildFoodObject(arr) {
    const food = {};
    for (let i = 0; i < arr.length; i += 2) {
        food[arr[i]] = Number(arr[i + 1]);
    }
    console.log(food);
}
