using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Hades.Domain.Model
{   public enum Genre {Rock = 0, Metal = 1, Alternative = 2, Electro = 3}
    public class Album
    {
        public int Id { get; set; }
        public Genre Genre { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Length { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<Song> Tracks { get; set; } = new();
        public List<Artist> TrackArtists { get; set; } = new();

    }
}
