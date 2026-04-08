function personalBMI(name, age, weight, height) {
    const heightInMeters = height / 100;
    const bmi = Math.round(weight / (heightInMeters * heightInMeters));

    let status;
    if (bmi < 18.5) status = 'underweight';
    else if (bmi < 25) status = 'normal';
    else if (bmi < 30) status = 'overweight';
    else status = 'obese';

    const chart = {
        name,
        personalInfo: { age, weight, height },
        BMI: bmi,
        status
    };

    if (status === 'obese') {
        chart.recommendation = 'admission required';
    }

    return chart;
}
