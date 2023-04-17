using Microsoft.AspNetCore.Mvc;

namespace jurnalmodul9_1302213109.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        public static List<Movie> _listNovie = new List<Movie>
        {
            new Movie("Title1", "Direc1", "Des1", new List<string> {"Star 1", "Star2"});

        };

         // GET: api/<Movies>
        [HttpGet]
        public IEnumerable<Movies1> Get()
        {
            return _listMovie;
        }

        // GET api/<Movies>/5
        [HttpGet("{id}")]
        public Movies1 Get(int id)
        {
            return _listMovie[id];
        }

        // POST api/<Movies>
        [HttpPost]
        public void Post([FromBody] Movies1 value)
        {
            _listMovie.Add(value);
        }

        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _listMovie.RemoveAt(id);
        }
    }
}