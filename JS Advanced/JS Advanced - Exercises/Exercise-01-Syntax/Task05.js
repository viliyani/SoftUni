function checkSpeed(speed, area) {
    const limits = {
        motorway: 130,
        interstate: 90,
        city: 50,
        residential: 20
    };

    const over = speed - limits[area];
    if (over <= 0) return;
    if (over <= 20) console.log('speeding');
    else if (over <= 40) console.log('excessive speeding');
    else console.log('reckless driving');
}
