using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Rafael.Millis.Models;
using Rafael.Millis.MovieRepository;


namespace Rafael.Millis.MoviesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        public MoviesController() { }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            Repository repo = new Repository();
            return repo.GetMovies();
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            Repository repo = new Repository();
            Movie m = repo.GetMovie(id);
            return m;
        }
    }
}
