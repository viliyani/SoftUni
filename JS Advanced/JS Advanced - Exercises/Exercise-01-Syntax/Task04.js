function universityWalk(steps, footprintMeters, speedKmh) {
    const distance = steps * footprintMeters;
    const walkSeconds = Math.round(distance / (speedKmh * 1000 / 3600));
    const breaks = Math.floor(distance / 500) * 60;
    const totalSeconds = walkSeconds + breaks;

    const hours = Math.floor(totalSeconds / 3600);
    const minutes = Math.floor((totalSeconds % 3600) / 60);
    const seconds = totalSeconds % 60;

    const pad = n => String(n).padStart(2, '0');
    console.log(`${pad(hours)}:${pad(minutes)}:${pad(seconds)}`);
}
