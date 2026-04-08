function solution(command) {
    if (command === 'upvote') {
        this.upvotes++;
    } else if (command === 'downvote') {
        this.downvotes++;
    } else if (command === 'score') {
        const total = this.upvotes + this.downvotes;
        const balance = this.upvotes - this.downvotes;

        let rating;
        if (total < 10) {
            rating = 'new';
        } else if (this.upvotes / total > 0.66) {
            rating = 'hot';
        } else if (balance >= 0 && (this.upvotes > 100 || this.downvotes > 100)) {
            rating = 'controversial';
        } else if (balance < 0) {
            rating = 'unpopular';
        } else {
            rating = 'new';
        }

        let reportedUp = this.upvotes;
        let reportedDown = this.downvotes;
        if (total > 50) {
            const inflate = Math.ceil(Math.max(this.upvotes, this.downvotes) * 0.25);
            reportedUp += inflate;
            reportedDown += inflate;
        }

        return [reportedUp, reportedDown, reportedUp - reportedDown, rating];
    }
}
