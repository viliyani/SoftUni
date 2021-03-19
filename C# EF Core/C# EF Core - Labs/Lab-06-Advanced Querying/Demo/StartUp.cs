using System;
using System.Linq;
using System.Text;
using LinqDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace LinqDemo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var db = new MusicXContext();

            // Example - Executing Native SQL Query
            var songs = db.Songs.FromSqlRaw("SELECT * FROM Songs WHERE Id < 5").ToList();

            foreach (var song in songs)
            {
                Console.WriteLine($"{song.Id} - {song.Name}");
            }

            // Example - Eager loading
            var artists = db
                .Artists
                .Include(a => a.SongArtists)
                .ThenInclude(sa => sa.Song)
                .Take(10)
                .ToList();

            foreach (var artist in artists)
            {
                Console.WriteLine($"{artist.Name} - {artist.SongArtists.First().Song.Name}");
            }
        }
    }
}
