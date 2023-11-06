using MovieManager.Model;

namespace MovieManager.Interface
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovie(int id);
        Task<Movie> CreateMovie(Movie movie);
        Task UpdateMovie(int id, Movie movie);
        Task DeleteMovie(int id);
    }
}
