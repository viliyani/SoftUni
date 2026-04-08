function result(commands) {
    const registry = Object.create(null);

    const handlers = {
        create(parts) {
            const name = parts[1];
            if (parts[2] === 'inherit' || parts[2] === 'inherits') {
                registry[name] = Object.create(registry[parts[3]]);
            } else {
                registry[name] = Object.create(null);
            }
        },
        set(parts) {
            const [, name, key, value] = parts;
            registry[name][key] = value;
        },
        print(parts) {
            const obj = registry[parts[1]];
            const entries = [];

            // Own properties first
            for (const key of Object.keys(obj)) {
                entries.push(`${key}:${obj[key]}`);
            }

            // Inherited properties from prototype chain
            let proto = Object.getPrototypeOf(obj);
            while (proto !== null) {
                for (const key of Object.keys(proto)) {
                    entries.push(`${key}:${proto[key]}`);
                }
                proto = Object.getPrototypeOf(proto);
            }

            console.log(entries.join(', '));
        }
    };

    for (const command of commands) {
        const parts = command.split(' ');
        handlers[parts[0]](parts);
    }
}

result(['create c1', 'create c2 inherits c1', 'set c1 color red', 'set c2 model new', 'print c1', 'print c2']);
