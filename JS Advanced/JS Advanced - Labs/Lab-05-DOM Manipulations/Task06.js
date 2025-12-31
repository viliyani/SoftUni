function validate() {
    const pattern = new RegExp(/^\S+@\S+\.\S+$/gm);

    const inputElement = document.getElementById('email');
    inputElement.addEventListener('change', onChange);

    function onChange(ev) {
        ev.target.classList.remove('error');
        if (! pattern.test(ev.target.value)) {
            ev.target.classList.add('error');
        }
    }
}