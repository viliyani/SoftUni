function solve(input) {
    class Song {
        constructor(typeList, name, time) {
            this.typeList = typeList;
            this.name = name;
            this.time = time;
        }
    }

    let n = input.shift();
    let last = input.pop();

    let songs = [];

    for (let i = 0; i < n; i++) {
        let [typeList, name, time] = input[i].split('_');

        songs.push(new Song(typeList, name, time));
    }

    songs = songs.filter(x => {
        if (last == "all") {
            return this;
        } else {
            if (x.typeList == last) {
                return this;
            }
        }
    });

    songs.forEach(x => console.log(x.name));
}

solve(
    [4,
        'favourite_DownTown_3:14',
        'listenLater_Andalouse_3:24',
        'favourite_In To The Night_3:58',
        'favourite_Live It Up_3:48',
        'listenLater']
);


