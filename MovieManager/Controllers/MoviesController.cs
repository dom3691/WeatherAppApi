using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManager.Interface;
using MovieManager.Model;

namespace MovieManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _moviesService;

        public MoviesController(IMovieService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            return Ok(await _moviesService.GetMovies());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await _moviesService.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> CreateMovie(Movie movie)
        {
            var createdMovie = await _moviesService.CreateMovie(movie);

            return CreatedAtAction(nameof(GetMovie), new { id = createdMovie.Id }, createdMovie);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, Movie movie)
        {
            try
            {
                await _moviesService.UpdateMovie(id, movie);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            try
            {
                await _moviesService.DeleteMovie(id);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
