function solve(...input) {
    const totalLength = input.reduce((sum, str) => sum + str.length, 0);
    console.log(totalLength);
    console.log(Math.floor(totalLength / input.length));
}
