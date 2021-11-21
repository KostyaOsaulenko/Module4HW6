using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW6.DataAccess.DbModels
{
    public class Genre
    {
        public Genre()
        {
            Songs = new List<Song>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<Song> Songs { get; set; }
    }
}
