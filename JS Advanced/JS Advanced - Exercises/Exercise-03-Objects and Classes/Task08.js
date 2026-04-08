function solve(tickets, sortBy) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    const result = tickets.map(t => {
        const [destination, price, status] = t.split('|');
        return new Ticket(destination, Number(price), status);
    });

    result.sort((a, b) => {
        if (sortBy === 'price') {
            return a.price - b.price;
        }
        return a[sortBy] < b[sortBy] ? -1 : a[sortBy] > b[sortBy] ? 1 : 0;
    });

    return result;
}
