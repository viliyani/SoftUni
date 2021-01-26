function solve(input) {
    let password = input.shift();

    let line = input.shift();

    while (line != 'Done') {
        let [command, firstArgument, secondArgument] = line.split(' ');

        switch (command) {
            case 'TakeOdd':
                let tempPassword = '';
                for (let i = 0; i < password.length; i++) {
                    if (i % 2 != 0) {
                        tempPassword += password[i];
                    }
                }
                console.log(tempPassword);
                password = tempPassword;
                break;

            case 'Cut':
                let index = Number(firstArgument);
                let length = Number(secondArgument);

                let substring = password.substring(index, index + length);
                password = password.replace(substring, '');
                console.log(password);
                break;

            case 'Substitute':
                if (password.includes(firstArgument)) {
                    while (password.includes(firstArgument)) {
                        password = password.replace(firstArgument, secondArgument);
                    }
                    console.log(password);
                } else {
                    console.log("Nothing to replace!");
                }
                break;
        }

        line = input.shift();
    }

    console.log(`Your password is: ${password}`);
}

solve(
    [
        'Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr ',
        'TakeOdd',
        'Cut 15 3',
        'Substitute :: -',
        'Substitute | ^',
        'Done'
    ]
);