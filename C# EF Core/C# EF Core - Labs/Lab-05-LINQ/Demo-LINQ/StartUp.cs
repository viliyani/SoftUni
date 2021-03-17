using System;
using System.Linq;
using System.Text;
using LinqDemo.Data;

namespace LinqDemo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            var context = new MusicXContext();

            // Example 1 - Aggregation
            var artists1 = context
                .Artists
                .Where(x => x.SongArtists.Count() > 50)
                .OrderByDescending(x => x.SongArtists.Count())
                .Select(x => new
                {
                    x.Name,
                    Count = x.SongArtists.Count()
                })
                .Take(5)
                .ToList();

            foreach (var artist in artists1)
            {
                Console.WriteLine(artist);
            }


            // Example 2 - Join
            var songs = context
                .Songs
                .Join(
                    context.Sources,
                    x => x.SourceId,
                    x => x.Id,
                    (song, source) => new
                    {
                        SongName = song.Name,
                        SourceName = source.Name
                    }
                )
                .Take(5)
                .ToList();

            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }


            // Example 3 - Group
            var groups = context
                .Artists
                .GroupBy(x => x.Name.Substring(0, 1))
                .Select(x => new
                {
                    FirstLetter = x.Key,
                    Count = x.Count(),
                })
                .ToList();

            foreach (var group in groups)
            {
                Console.WriteLine(group);
            }


            // Example 4 - SelectMany
            var songs2 = context
                .Artists
                .SelectMany(x => x.SongArtists.Select(sa => x.Name + " - " + sa.Song.Name))
                .Take(10)
                .ToList();

            foreach (var song in songs2)
            {
                Console.WriteLine(song);
            }

        }
    }
}
