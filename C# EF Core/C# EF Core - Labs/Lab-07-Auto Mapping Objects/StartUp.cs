using System;
using System.Linq;
using LinqDemo.Data;
using AutoMapper;
using LinqDemo.Models;

namespace LinqDemo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var db = new MusicXContext();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Song, SongInfoDto>();
            });

            var mapper = config.CreateMapper();

            Song song = db.Songs.Where(x => x.Id == 10).First();

            var songDto = mapper.Map<SongInfoDto>(song);
        }
    }

    public class SongInfoDto
    {
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public string SourceName { get; set; }
    }
}
