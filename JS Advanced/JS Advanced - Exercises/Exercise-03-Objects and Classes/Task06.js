function systemComponents(input) {
    const systems = {};

    for (const line of input) {
        const [system, component, subcomponent] = line.split(' | ');

        if (!systems[system]) systems[system] = {};
        if (!systems[system][component]) systems[system][component] = [];
        systems[system][component].push(subcomponent);
    }

    const sortedSystems = Object.keys(systems).sort((a, b) => {
        const diff = Object.keys(systems[b]).length - Object.keys(systems[a]).length;
        return diff !== 0 ? diff : a.toLowerCase().localeCompare(b.toLowerCase());
    });

    for (const system of sortedSystems) {
        console.log(system);

        const sortedComponents = Object.keys(systems[system]).sort(
            (a, b) => systems[system][b].length - systems[system][a].length
        );

        for (const component of sortedComponents) {
            console.log(` |||${component}`);
            for (const sub of systems[system][component]) {
                console.log(` ||||||${sub}`);
            }
        }
    }
}
