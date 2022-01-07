using Microsoft.AspNetCore.Mvc;

namespace Belajar_Api_Net.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {

        private static readonly string[] movies = new[]
        {
            "avenger", "Monata", "Spiderman"
        };

        private readonly ILogger<MovieController> _logger;

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMovieForecast")]
        public IEnumerable<MoviesResp> Get()
        {
            TagsResp _tags = new TagsResp();
            _tags.name = "coba";
            _tags.id = 1;

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
