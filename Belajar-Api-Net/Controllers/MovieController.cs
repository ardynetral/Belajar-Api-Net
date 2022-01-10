using Microsoft.AspNetCore.Mvc;
using Belajar_Api_Net.Domains.Movie.Repositories;
using Belajar_Api_Net.Domains.Movie.Entites;

namespace Belajar_Api_Net.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {

        

        private static readonly string[] movies = new[]
        {
            "avenger", "Monata", "Spiderman"
        };

        private readonly MovieRepository _movieRepository;
        private ILogger Logger { get; }


        public MovieController(ILoggerFactory logFactory, MovieRepository movieRepository)
        {
            Logger = logFactory.CreateLogger<Startup>();
            _movieRepository = movieRepository;
        }

        [HttpGet(Name = "GetMovieForecast")]
        public IEnumerable<MoviesResp> Get()
        {
            TagsResp _tags = new TagsResp();
            _tags.name = "coba";
            _tags.id = 1;

            var moviee = _movieRepository.GetListMovie();
            Logger.LogInformation("lihat isinya : ", moviee);

            return Enumerable.Range(1, 3).Select(index => new MoviesResp
            {
                Date = DateTime.Now.AddDays(index),
                Title = movies[Random.Shared.Next(movies.Length)],
                Overview = "",
                Tags = _tags
            })
            .ToArray();
        }
    }
}
