function checkDigits(n) {
    const digits = String(n).split('');
    const allSame = digits.every(d => d === digits[0]);
    const sum = digits.reduce((acc, d) => acc + Number(d), 0);
    console.log(allSame);
    console.log(sum);
}
