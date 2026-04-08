function storeCatalogue(input) {
    const catalogue = {};

    for (const line of input) {
        const [name, price] = line.split(' : ');
        const initial = name[0].toUpperCase();

        if (!catalogue[initial]) {
            catalogue[initial] = [];
        }
        catalogue[initial].push({ name, price: Number(price) });
    }

    const sortedInitials = Object.keys(catalogue).sort();

    for (const initial of sortedInitials) {
        console.log(initial);
        catalogue[initial]
            .sort((a, b) => a.name.localeCompare(b.name))
            .forEach(p => console.log(`  ${p.name}: ${p.price}`));
    }
}
