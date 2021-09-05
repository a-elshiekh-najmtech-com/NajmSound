using System.Collections.Generic;

namespace NajmSound.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string ReleaseYear { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    
        public IEnumerable<Song> Songs { get; set; }

    }
}
