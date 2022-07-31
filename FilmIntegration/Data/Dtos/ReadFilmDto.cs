using System.ComponentModel.DataAnnotations;

namespace FilmIntegration.Data.Dtos
{
    public class ReadFilmDto
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string OverView { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
