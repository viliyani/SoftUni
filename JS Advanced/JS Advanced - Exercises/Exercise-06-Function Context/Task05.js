function getArticleGenerator(articles) {
    return function () {
        if (articles.length === 0) return;
        const text = articles.shift();
        const article = document.createElement('article');
        article.textContent = text;
        document.getElementById('content').appendChild(article);
    };
}
