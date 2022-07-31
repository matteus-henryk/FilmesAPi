namespace FilmIntegration.Data.Dtos
{
    public class ResponseFilmsDto
    {
        public int page { get; set; }
        public List<ResponseFilmDto>? results { get; set; }
        public long total_pages { get; set; }
        public long total_results { get; set; }

    }

    public class ResponseFilmDto 
    {
        public decimal popularity { get; set; }
        public long vote_count { get; set; }
        public string? poster_path { get; set; }
        public long id { get; set; }
        public bool adult { get; set; }
        public string? background_path { get; set; }
        public string? original_language { get; set; }
        public string? original_title { get; set; }
        public List<int>? genre_ids { get; set; }
        public string? title { get; set; }
        public decimal vote_average { get; set; }
        public string? overview { get; set; }
        public string? release_date { get; set; }
        public bool video { get; set; }
    }

}
