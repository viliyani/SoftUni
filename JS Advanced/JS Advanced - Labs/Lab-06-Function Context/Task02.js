function Person(firstName, lastName) {
    let _firstName = firstName;
    let _lastName = lastName;

    Object.defineProperty(this, 'firstName', {
        get() { return _firstName; },
        set(value) { _firstName = value; }
    });

    Object.defineProperty(this, 'lastName', {
        get() { return _lastName; },
        set(value) { _lastName = value; }
    });

    Object.defineProperty(this, 'fullName', {
        get() { return `${_firstName} ${_lastName}`; },
        set(value) {
            const parts = value.split(' ');
            if (parts.length !== 2 || !parts[0] || !parts[1]) return;
            _firstName = parts[0];
            _lastName = parts[1];
        }
    });
}