function autoEngineeringCompany(input) {
    const brands = {};

    for (const line of input) {
        const [brand, model, count] = line.split(' | ');
        const produced = Number(count);

        if (!brands[brand]) brands[brand] = {};
        brands[brand][model] = (brands[brand][model] || 0) + produced;
    }

    for (const brand of Object.keys(brands)) {
        console.log(brand);
        for (const model of Object.keys(brands[brand])) {
            console.log(`###${model} -> ${brands[brand][model]}`);
        }
    }
}
