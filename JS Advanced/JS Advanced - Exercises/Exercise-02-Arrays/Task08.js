function ticTacToe(moves) {
    const board = [
        [false, false, false],
        [false, false, false],
        [false, false, false]
    ];

    function checkWin(player) {
        for (let i = 0; i < 3; i++) {
            if (board[i].every(c => c === player)) return true;
            if (board[0][i] === player && board[1][i] === player && board[2][i] === player) return true;
        }
        if (board[0][0] === player && board[1][1] === player && board[2][2] === player) return true;
        if (board[0][2] === player && board[1][1] === player && board[2][0] === player) return true;
        return false;
    }

    function isFull() {
        return board.every(row => row.every(cell => cell !== false));
    }

    function printBoard() {
        board.forEach(row => console.log(row.join('\t')));
    }

    let currentPlayer = 'X';

    for (let i = 0; i < moves.length; i++) {
        const [r, c] = moves[i].split(' ').map(Number);

        if (board[r][c] !== false) {
            console.log("This place is already taken. Please choose another!");
            continue;
        }

        board[r][c] = currentPlayer;

        if (checkWin(currentPlayer)) {
            console.log(`Player ${currentPlayer} wins!`);
            printBoard();
            return;
        }

        if (isFull()) {
            console.log("The game ended! Nobody wins :(");
            printBoard();
            return;
        }

        currentPlayer = currentPlayer === 'X' ? 'O' : 'X';
    }
}
