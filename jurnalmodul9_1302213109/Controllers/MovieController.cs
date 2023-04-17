using Microsoft.AspNetCore.Mvc;

namespace jurnalmodul9_1302213109.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        public static List<Movie> listNovie = new List<Movie>
        {
            new Movie("Title1", "Direc1", "Des1", new List<string> {"Star 1", "Star2"});
            new Movie("Title2", "Direc2", "Des2", new List<string> {"Star 3", "Star4"});

        };

        private readonly ILogger<MovieController> _logger;
          
        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<jurnalmodul9_1302213109.Movie> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Movie
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}