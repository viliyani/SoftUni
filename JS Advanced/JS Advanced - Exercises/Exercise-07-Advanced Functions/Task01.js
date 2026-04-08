function sortArray(arr, order) {
    if (order === 'asc') {
        return arr.slice().sort((a, b) => a - b);
    } else if (order === 'desc') {
        return arr.slice().sort((a, b) => b - a);
    }
}
