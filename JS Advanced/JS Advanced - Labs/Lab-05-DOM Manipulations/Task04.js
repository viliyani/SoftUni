function attachGradientEvents() {
    const gradient = document.getElementById('gradient');
    const result = document.getElementById('result');
    
    gradient.addEventListener('mousemove', getPercentage);

    function getPercentage(ev) {
        result.textContent = `${Math.floor((ev.offsetX / ev.target.clientWidth) * 100)}%`;
    }
}