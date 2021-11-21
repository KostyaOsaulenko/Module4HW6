using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW6.DataAccess.DbModels
{
    public class ArtistSong
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
        public int SongId { get; set; }
        public virtual Song Song { get; set; }
    }
}
