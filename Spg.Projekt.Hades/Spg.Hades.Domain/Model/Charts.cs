using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Hades.Domain.Model
{   public enum Category { Rock = 0, Metal = 1, Alternative = 2, Electro = 3 }
    public class Charts
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Category Category { get; set; }
        public DateTime Year { get; set; }
        public List<Album> AlbumCharts { get; set; } = new();
        public List<Song> SongCharts { get; set; } = new();
        public List<Artist> ArtistCharts { get; set; } = new();



    }
}
