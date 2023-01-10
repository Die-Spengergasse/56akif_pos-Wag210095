using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Hades.Domain.Model
{
    public class Playlist
    {
        public int Id { get; set; } //pk
        public int SongsCount { get; } //ReadOnly, weil wenn nur zB 5 Songs in der Playlist ist, soll keiner das auf 10 setzen können
        public float Length { get; set; } //timespan
        public List<Song> Songs { get; set; } = new();
        public List<Album> Albums { get; set; } = new();
        public List<Artist> Artists { get; set; } = new();
        public Listener ListenerNavigation { get; set; } = default!;

    }
}
