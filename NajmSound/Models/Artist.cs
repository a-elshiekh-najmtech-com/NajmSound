using System;
using System.Collections.Generic;

namespace NajmSound.Models
{

    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Info { get; set; }
        public string InstgramUri { get; set; }
        public Genre Genre { get; set; }
        public DateTime JoinDate { get; set; }

        public ApplicationUser? User { get; set; }
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Song> Songs { get; set; }
    }
}
