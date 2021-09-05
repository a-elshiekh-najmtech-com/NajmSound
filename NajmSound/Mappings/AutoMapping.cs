using AutoMapper;
using NajmSound.Data;
using NajmSound.Models;
using NajmSound.ViewModel;

namespace NajmSound.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Artist, ArtistListViewModel>();
            CreateMap<Artist, ArtistViewModel>();

            CreateMap<Album, AlbumListViewModel>();

            CreateMap<Album, AlbumViewModel>()
                .ForMember(x=>x.Artist,opt=>opt.MapFrom(y=>y.Artist.Name));

            CreateMap<Song, SongListViewModel>();
            CreateMap<Song, SongViewModel>();

        }

    }
}
