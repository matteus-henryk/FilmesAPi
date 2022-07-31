using AutoMapper;
using FilmIntegration.Data;
using FilmIntegration.Data.Dtos;
using FilmIntegration.Models;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FilmIntegration.Service
{
    public class FilmService
    {
        private AppDbContext _context;
        private TMDBClientService _tMDBClientService;
        private IMapper _mapper;

        public FilmService(AppDbContext context, TMDBClientService tMDBClientService, IMapper mapper)
        {
            _context = context;
            _tMDBClientService = tMDBClientService;
            _mapper = mapper;
        }

        public Result CreateListFilms(string authorization)
        {
            var payload = _tMDBClientService.CreateListFilms(authorization);

            if (payload == null) return Result.Fail("Não foi possivel recuperar e salvar os filmes!");

            _context.Films.AddRange(payload.results.Select(film => new Film() 
            {
                Id = new Guid(),
                Title = film.title,
                OverView = film.overview,
                ReleaseDate = Convert.ToDateTime(film.release_date)
            }).ToList());

            _context.SaveChanges();

            return Result.Ok();
        }

        public List<ReadFilmDto> GetFilm()
        {
            var films = _context.Films.ToList();

            return _mapper.Map<List<ReadFilmDto>>(films);
        }

        public ReadFilmDto CreateFilm(CreateFilmDto body)
        {
            var film = _mapper.Map<Film>(body);
            _context.Add(film);
            _context.SaveChanges();

            return _mapper.Map<ReadFilmDto>(film);
        }

        public Result UpdateFilm(Guid id, UpdateFilmDto body)
        {
            var film = _context.Films.FirstOrDefault(film => film.Id == id);

            if (film == null) return Result.Fail("Filme não encontrado");

            _mapper.Map(body, film);
            _context.SaveChanges();

            return Result.Ok();
        }

        public Result DeleteFilm(Guid id)
        {
            var film = _context.Films.FirstOrDefault(film => film.Id == id);

            if (film == null) return Result.Fail("Filme não encontrado");

            _context.Remove(film);
            _context.SaveChanges();

            return Result.Ok();
        }

        public ReadFilmDto GetFilmId(Guid id)
        {
            var film = _context.Films.Where(film => film.Id == id).ToList();

            if(film != null)
            {
                return _mapper.Map<ReadFilmDto>(film.FirstOrDefault());
            }

            return null;
        }
    }
}
