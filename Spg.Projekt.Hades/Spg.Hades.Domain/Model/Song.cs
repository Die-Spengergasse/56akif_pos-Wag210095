using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Hades.Domain.Model
{
    public class Song
    {
        public int Id { get; set; }
        public string SongName { get; set; } = string.Empty;
        public float SongLenght { get; set; }

        public List<Artist> Artists = new List<Artist>();
    }
}
