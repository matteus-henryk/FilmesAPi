using FilmesAPI.Models;
using System;

namespace FilmesApi.Data.Dtos.Sessao
{
    public class ReadSessaoDto
    {
        public Cinema Cinema { get; set; }
        public Filme Filme { get; set; }
        public int Id { get; set; }
        public DateTime HorarioDeEncerramentoDaSessao { get; set; }
        public DateTime HorarioDeInicioDaSessao { get; set; }
    }
}
