function heroicInventory(input) {
    const heroes = [];

    for (const line of input) {
        const [name, level, itemsStr] = line.split(' / ');
        const items = itemsStr ? itemsStr.split(', ') : [];
        heroes.push({ name, level: Number(level), items });
    }

    return JSON.stringify(heroes);
}
