using FilmIntegration.Service;
using Microsoft.AspNetCore.Mvc;

namespace FilmIntegration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        private FilmService _filmService;

        public FilmController(FilmService filmService)
        {
            _filmService = filmService;
        }

        [HttpGet("create")]
        public IActionResult CreateListFilms([FromHeader] string authorization)
        {
            var createdListFilms = _filmService.CreateListFilms(authorization);

            if (createdListFilms.IsFailed) return NotFound();

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetFilmId([FromRoute] Guid id)
        {
            var film = _filmService.GetFilmId(id);

            if (film == null) return NotFound();

            return Ok(film);
        }

        [HttpGet]
        public IActionResult GetFilm()
        {
            var films = _filmService.GetFilm();

            if (films == null) return NotFound();

            return Ok(films);
        }
    }
}
