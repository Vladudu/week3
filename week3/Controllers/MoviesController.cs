using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        static List<Models.Movie> listamovies = new List<Models.Movie>()
        {
            new Models.Movie() { ID = Guid.NewGuid(), Name = "Movie 1", Year = 2020, Lenght = "2 ore" },
            new Models.Movie() { ID = Guid.NewGuid(), Name = "Movie 1", Year = 2020, Lenght = "2 ore" },
            new Models.Movie() { ID = Guid.NewGuid(), Name = "Movie 1", Year = 2020, Lenght = "2 ore" },
            new Models.Movie() { ID = Guid.NewGuid(), Name = "Movie 1", Year = 2020, Lenght = "2 ore" },
            new Models.Movie() { ID = Guid.NewGuid(), Name = "Movie 1", Year = 2020, Lenght = "2 ore" },
        };

        [HttpGet]
        public Models.Movie[] Get()
        {
            return listamovies.ToArray();
        }

        [HttpPost]
        public void Post([FromBody] Models.Movie moviee)
        {
            if (moviee.ID == Guid.Empty)
                moviee.ID = Guid.NewGuid();

            listamovies.Add(moviee);
        }

        [HttpPut]
        public void Put([FromBody] Models.Movie moviee)
        {
            Models.Movie currentMovie = listamovies.FirstOrDefault(x => x.ID == moviee.ID);
            currentMovie.Name = moviee.Name;
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            listamovies.RemoveAll(movie => movie.ID == id);

        }

    }
}


