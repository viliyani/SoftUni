function solve(dayNumber) {
    const days = [
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday",
        "Sunday"
    ];

    if (dayNumber >= 1 && dayNumber <= 7) {
        console.log(days[dayNumber - 1]);
    } else {
        console.log("Invalid day!");
    }
}