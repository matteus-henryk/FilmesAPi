using FilmIntegration.Data.Dtos;
using FluentResults;
using System.Text.Json;

namespace FilmIntegration.Service
{
    public class TMDBClientService
    {
        private HttpClient _httpClient;
        private const string tmdbURL = "https://api.themoviedb.org/3/movie/popular";
        private const string apiKey = "d969ba4887637c0c29db17b3f3e37a66";

        public TMDBClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public ResponseFilmsDto  CreateListFilms(string authorization)
        {
            _httpClient.DefaultRequestHeaders.Add("Bearer", authorization);

            var request = _httpClient.GetAsync($"{tmdbURL}?api_key={apiKey}&language=pt-BR").Result;

            if (!request.IsSuccessStatusCode) return null;

            var response = request.Content.ReadAsStringAsync().Result;

            var result =  JsonSerializer.Deserialize<ResponseFilmsDto>(response);

            return result;
        }

    }
}
