using System.ComponentModel.DataAnnotations;

namespace FilmIntegration.Data.Dtos
{
    public class CreateFilmDto
    {
        [Required(ErrorMessage = "O campo de titulo é obrigatório")]
        public string Title { get; set; }
        [Required(ErrorMessage = "O campo de descrição é obrigatório")]
        public string OverView { get; set; }
        [Required(ErrorMessage = "O campo de data de lançamento é obrigatório")]
        public DateTime ReleaseDate { get; set; }
    }
}
