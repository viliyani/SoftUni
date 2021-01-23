function solve(count, type, day) {
    let unitPrice = 0.0;

    if (day == "Friday") {
        if (type == "Students") {
            unitPrice = 8.45;
        } else if (type == "Business") {
            unitPrice = 10.90;
        } else if (type == "Regular") {
            unitPrice = 15.00;
        }
    } else if (day == "Saturday") {
        if (type == "Students") {
            unitPrice = 9.80;
        } else if (type == "Business") {
            unitPrice = 15.60;
        } else if (type == "Regular") {
            unitPrice = 20.00;
        }
    } else if (day == "Sunday") {
        if (type == "Students") {
            unitPrice = 10.46;
        } else if (type == "Business") {
            unitPrice = 16.00;
        } else if (type == "Regular") {
            unitPrice = 22.50;
        }
    }


    if (type == "Students" && count >= 30) {
        unitPrice -= unitPrice * 0.15;
    }

    if (type == "Business" && count >= 100) {
        count -= 10;
    }

    if (type == "Regular" && count >= 10 && count <= 20) {
        unitPrice -= unitPrice * 0.05;
    }


    let total = count * unitPrice;
    total = total.toFixed(2);

    console.log(`Total price: ${total}`);
}