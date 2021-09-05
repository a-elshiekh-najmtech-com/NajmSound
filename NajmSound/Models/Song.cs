namespace NajmSound.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int ArtistId { get; set; }
        public int AlbumId { get; set; }
        public string About { get; set; }
        public string Length { get; set; }
        public string ReleaseYear { get; set; }


        public Artist Artist { get; set; }
        public Album Album { get; set; }
    }
}
