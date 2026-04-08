function extractWords(text) {
    const words = text.match(/\b[a-zA-Z]+\b/g);
    console.log(words.map(w => w.toUpperCase()).join(', '));
}
