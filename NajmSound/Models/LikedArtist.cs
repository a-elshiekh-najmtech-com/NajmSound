namespace NajmSound.Models
{
    public class LikedArtist
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public string UserId { get; set; }

        public Artist Artist { get; set; }
        public ApplicationUser User { get; set; }
    }
}
