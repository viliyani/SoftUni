function result(commands) {
    const collection = [];

    const handler = {
        add(str) {
            collection.push(str);
        },
        remove(str) {
            collection.filter(item => item === str)
                .forEach(() => collection.splice(collection.indexOf(str), 1));
        },
        print() {
            console.log(collection.join(','));
        }
    };

    for (const command of commands) {
        const separatorIndex = command.indexOf(' ');
        const cmd = separatorIndex === -1 ? command : command.slice(0, separatorIndex);
        const arg = separatorIndex === -1 ? '' : command.slice(separatorIndex + 1);

        if (!Object.prototype.hasOwnProperty.call(handler, cmd)) {
            throw new Error(`Unknown command: "${cmd}"`);
        }

        handler[cmd](arg);
    }
}

result(['add hello', 'add again', 'remove hello', 'add again', 'print']);
result(['add pesho', 'add george', 'add peter', 'remove peter', 'print']);
