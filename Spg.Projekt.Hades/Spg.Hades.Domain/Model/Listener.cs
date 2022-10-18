using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Hades.Domain.Model
{
     public enum Genders { Male, Female, Others};
    public class Listener
    {
        public string Listenernumber { get; set; } = string.Empty; //(warum empty wenn pk?)
        public Genders Gender { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public DateTime Birthdate { get; set; }
        public string EMail { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }
        public List<Playlist> Playlists { get; set; } = new();


    }
}
