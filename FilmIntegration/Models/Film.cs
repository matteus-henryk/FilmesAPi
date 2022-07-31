using System.ComponentModel.DataAnnotations;

namespace FilmIntegration.Models
{
    public class Film
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string OverView { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
