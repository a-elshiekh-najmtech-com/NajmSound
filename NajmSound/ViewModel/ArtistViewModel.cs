using NajmSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NajmSound.ViewModel
{
    public class ArtistListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Info { get; set; }
        public string InstgramUri { get; set; }

        public int SongsCount { get; set; }
        public int AlbumsCount { get; set; }
        public int LikesCount { get; set; }

        public bool liked { get; set; }
    }

    public class ArtistViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string InstgramUri { get; set; }

        public IEnumerable<SongListViewModel> Songs { get; set; }
        public IEnumerable<AlbumListViewModel> Albums { get; set; }
        public int LikesCount { get; set; }
        public int SongsCount => Songs.Count();
        public int AlbumsCount => Albums.Count();
    }

    public class SongListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public string Artist { get; set; }
        public string Length { get; set; }
        public string ReleaseYear { get; set; }

        public int LikesCount { get; set; }
        public bool Liked { get; set; }
    }

    public class SongViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public string Artist { get; set; }
        public string Length { get; set; }
        public string ReleaseYear { get; set; }
        public string About { get; set; }

        public int LikesCount { get; set; }
        public bool Liked { get; set; }
    }


    public class AlbumListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public string Artist { get; set; }
        public string About { get; set; }
        public string ReleaseYear { get; set; }

        public int SongsCount { get; set; }
    }

    public class AlbumViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public string Artist { get; set; }
        public string About { get; set; }
        public string ReleaseYear { get; set; }
        public IEnumerable<SongListViewModel> Songs { get; set; }
        public int SongsCount => Songs.Count();
    }

}
