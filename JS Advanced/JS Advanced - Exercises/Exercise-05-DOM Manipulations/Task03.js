function lockedProfile() {
    Array.from(document.querySelectorAll('.profile button')).forEach((btn) => {
        btn.addEventListener('click', onClick);
    });

    function onClick(ev) {
        const profile = ev.target.parentElement;
        const isUnlocked = profile.querySelector(
            'input[type="radio"][value="unlock"]'
        ).checked;

        if (isUnlocked) {
            const infoDiv = profile.querySelector('div');
            if (ev.target.textContent === 'Show more') {
                infoDiv.style.display = 'block';
                ev.target.textContent = 'Hide it';
            } else {
                infoDiv.style.display = 'none';
                ev.target.textContent = 'Show more';
            }
        }
    }
}
