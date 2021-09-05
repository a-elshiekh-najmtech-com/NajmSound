namespace NajmSound.Models
{
    public class LikedSong
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public string UserId { get; set; }

        public Song Song { get; set; }
        public ApplicationUser User { get; set; }
    }
}
