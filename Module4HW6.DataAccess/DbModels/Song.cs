using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW6.DataAccess.DbModels
{
    public class Song
    {
        public Song()
        {
            ArtistSongs = new List<ArtistSong>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual List<ArtistSong> ArtistSongs { get; set; }
    }
}
