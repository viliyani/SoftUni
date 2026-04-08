function result() {
    let el1, el2, elResult;

    return {
        init(selector1, selector2, resultSelector) {
            el1 = document.querySelector(selector1);
            el2 = document.querySelector(selector2);
            elResult = document.querySelector(resultSelector);
            return this;
        },
        add() {
            elResult.value = Number(el1.value) + Number(el2.value);
            return this;
        },
        subtract() {
            elResult.value = Number(el1.value) - Number(el2.value);
            return this;
        }
    };
}
