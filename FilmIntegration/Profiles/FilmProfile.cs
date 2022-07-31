using AutoMapper;
using FilmIntegration.Data.Dtos;
using FilmIntegration.Models;

namespace FilmIntegration.Profiles
{
    public class FilmProfile : Profile
    {
        public FilmProfile()
        {
            CreateMap<Film, ReadFilmDto>();
            CreateMap<CreateFilmDto, Film>();
            CreateMap<UpdateFilmDto, Film>();
        }
    }
}
